using Hylian.RIS.API.Services.Interfaces;
using Hylian.RIS.API.Repository.Interfaces;
using Hylian.RIS.API.ViewModels;
using System.Text;

namespace Hylian.RIS.API.Services
{
    internal class ResultPocService : IResultPocService
    {
        private readonly IOrganisationRepository _organisationRepository;
        private readonly IJerseyRepository _jerseyRepository;

        public ResultPocService(IOrganisationRepository organisationRepository, IJerseyRepository jerseyRepository)
        {
            _organisationRepository = organisationRepository;
            _jerseyRepository = jerseyRepository;
        }

        public async Task PostResult(RaceResult raceResult, string dir)
        {
            if (!new DirectoryInfo(dir).Exists)
            {
                new DirectoryInfo(dir).Create();
            }
            var organisation = await _organisationRepository.GetByID(raceResult.OrganisationID);
            var jerseys = await _jerseyRepository.GetByCompetition(organisation.Competition);
            var fileName = $"{organisation.Name.Replace(" ","").Replace(".", "")}_{raceResult.Date.ToString("yyyy-MM-dd")}.txt";
            var sb = new StringBuilder();
            sb.AppendLine($"Race: {raceResult.RaceNumber}");
            sb.AppendLine("Results:");
            if (raceResult.Results != null && raceResult.Results.Any())
            {
                var results = Sort(raceResult.Results);
                for (int count = 0; count < results.Count; count++)
                {
                    var run = results[count];
                    var isOK = run.ResultCode.ToUpperInvariant() == "OK";
                    var pos = isOK ? $"{count + 1}." : "  ";
                    var jerseyName = jerseys.FirstOrDefault(j => j.Number == run.JerseyNr)?.Names.First(n => n.LanguageCode == "en").Text;
                    sb.AppendLine($"    {pos}  {run.JerseyNr} {jerseyName?.PadRight(12)} {(isOK ? $"{new TimeOnly(run.TimeTicks).Second.ToString().PadLeft(3)}.{new TimeOnly(run.TimeTicks).Millisecond.ToString("000")}" : run.ResultCode.ToUpperInvariant().PadLeft(4))} ");
                }
            }
            sb.AppendLine();
            sb.AppendLine();

            var filepath = Path.Combine(dir, fileName);
            await File.AppendAllTextAsync(filepath, sb.ToString());
        }

        private List<RunResult> Sort(IList<RunResult> results)
        {
            var okResults = new List<RunResult>();
            var nrResults = new List<RunResult>();
            var dnfResults = new List<RunResult>();
            var dnsResults = new List<RunResult>();
            var disResults = new List<RunResult>();
            foreach (var run in results)
            {
                switch (run.ResultCode.ToLowerInvariant())
                {
                    case "nr": nrResults.Add(run); break;
                    case "dnf": dnfResults.Add(run); break;
                    case "dns": dnsResults.Add(run); break;
                    case "dis": disResults.Add(run); break;
                    default: okResults.Add(run); break;
                }
            }
            okResults = okResults.OrderBy(r => r.TimeTicks).ToList();
            var returnResults = new List<RunResult>();
            returnResults.AddRange(okResults);
            returnResults.AddRange(nrResults);
            returnResults.AddRange(dnfResults);
            returnResults.AddRange(dnsResults);
            returnResults.AddRange(disResults);

            return returnResults;
        }
    }
}