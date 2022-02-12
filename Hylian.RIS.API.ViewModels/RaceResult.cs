namespace Hylian.RIS.API.ViewModels
{
    public class RaceResult
    {
        public Guid OrganisationID { get; set; }
        public DateTime Date { get; set; }
        public string RaceNumber { get; set; }
        public IList<RunResult> Results { get; set; }
    }
}
