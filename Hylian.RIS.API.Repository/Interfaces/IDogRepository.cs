using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IDogRepository
    {
        Task AddLicenses(Dog dog, List<RaceLicense> licenses, bool saveChanges = true);
        Task ChangeClass(Dog dog, RaceClass raceClass, bool saveChanges = true);
        Task Deactivate(Dog dog);
        Task DeactivateLicense(Dog dog, RaceCompetition competition, bool saveChanges = true);
        IQueryable<Dog> GetAll(bool active = true);
        IQueryable<Dog> GetBy(Breed breed = null, Sex sex = null, RaceClass raceClass = null, bool active = true);
        IQueryable<Dog> GetByChip(string chip);
        IQueryable<Dog> GetByID(Guid id);
        IQueryable<Dog> GetByAccount(Account account, bool active = true);
        IQueryable<Dog> GetByOwner(Person owner, bool active = true);
        IQueryable<Dog> GetByEvent(RaceEvent raceEvent, bool active = true);
        Task Save(Dog dog, bool saveChanges = true);
    }
}