using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceCompetitionRepository
    {
        IQueryable<RaceCompetition> GetAll(bool? isProffesional = null);
        IQueryable<RaceCompetition> GetByID(Guid id);
        Task Save(RaceCompetition competition, bool saveChanges = true);
    }
}