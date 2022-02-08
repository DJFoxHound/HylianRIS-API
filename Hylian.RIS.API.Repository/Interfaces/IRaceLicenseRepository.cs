using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceLicenseRepository
    {
        IQueryable<RaceLicense> GetAll(bool? isActive = null);
        IQueryable<RaceLicense> GetByBreed(Breed breed, RaceCompetition competition = null, bool? isActive = null);
        IQueryable<RaceLicense> GetByClass(RaceClass raceClass, bool? isActive = null);
        IQueryable<RaceLicense> GetByCompetition(RaceCompetition competition, bool? isActive = null);
        IQueryable<RaceLicense> GetByDog(Dog dog, bool? isActive = null);
        IQueryable<RaceLicense> GetByID(Guid id);
        IQueryable<RaceLicense> GetByLicenseNumber(string licenseNumber, RaceCompetition competition = null, bool? isActive = null);
        Task Save(RaceLicense license, bool saveChanges = true);
    }
}