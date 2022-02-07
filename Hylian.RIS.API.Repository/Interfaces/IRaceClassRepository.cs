using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceClassRepository
    {
        IQueryable<RaceClass> GetAll(RaceCompetition competition = null);
        IQueryable<RaceClass> GetByBreed(Breed breed, RaceCompetition competition = null);
        IQueryable<RaceClass> GetByID(Guid id);
        Task Save(RaceClass raceClass, bool saveChanges = true);
    }
}