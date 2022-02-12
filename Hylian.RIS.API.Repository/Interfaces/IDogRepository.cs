using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IDogRepository
    {
        Task AddLicenses(Dog dog, List<RaceLicense> licenses, bool saveChanges = true);
        Task ChangeClass(Dog dog, RaceClass raceClass, bool saveChanges = true);
        Task Deactivate(Dog dog);
        Task DeactivateLicense(Dog dog, RaceCompetition competition, bool saveChanges = true);
        Task<IList<Dog>> GetAll(bool active = true);
        Task<IList<Dog>> GetBy(Breed breed = null, Sex sex = null, RaceClass raceClass = null, bool active = true);
        Task<Dog> GetByChip(string chip);
        Task<Dog> GetByID(Guid id);
        Task<IList<Dog>> GetByAccount(Account account, bool active = true);
        Task<IList<Dog>> GetByOwner(Person owner, bool active = true);
        Task<IList<Dog>> GetByEvent(RaceEvent raceEvent, bool active = true);
        Task<IList<Dog>> GetByRace(Race race, bool active = true);
        Task Save(Dog dog, bool saveChanges = true);
    }
}