using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceClassRepository
    {
        Task<IList<RaceClass>> GetAll(RaceCompetition competition = null);
        Task<IList<RaceClass>> GetByBreed(Breed breed, RaceCompetition competition = null);
        Task<RaceClass> GetByID(Guid id);
        Task Save(RaceClass raceClass, bool saveChanges = true);
    }
}