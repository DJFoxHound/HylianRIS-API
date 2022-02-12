using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceLicenseRepository
    {
        Task<IList<RaceLicense>> GetAll(bool? isActive = null);
        Task<IList<RaceLicense>> GetByBreed(Breed breed, RaceCompetition competition = null, bool? isActive = null);
        Task<IList<RaceLicense>> GetByClass(RaceClass raceClass, bool? isActive = null);
        Task<IList<RaceLicense>> GetByCompetition(RaceCompetition competition, bool? isActive = null);
        Task<IList<RaceLicense>> GetByDog(Dog dog, bool? isActive = null);
        Task<RaceLicense> GetByID(Guid id);
        Task<IList<RaceLicense>> GetByLicenseNumber(string licenseNumber, RaceCompetition competition = null, bool? isActive = null);
        Task Save(RaceLicense license, bool saveChanges = true);
    }
}