using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceTypeRepository
    {
        IQueryable<RaceType> GetAll(bool? isOfficial = null);
        IQueryable<RaceType> GetByCompetition(RaceCompetition competition, bool? isOfficial = null);
        IQueryable<RaceType> GetByID(Guid id);
        Task Save(RaceType type, bool saveChanges = true);
    }
}