using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class DogRepository : IDogRepository
    {
        DbaseContext db;

        public DogRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<Dog> GetAll(bool active = true)
        {
            return db.Dogs.Where(x => active ? x.Active == true : true);
        }
        public IQueryable<Dog> GetBy(Breed breed = null, Sex sex = null, RaceClass raceClass = null, bool active = true)
        {
            return db.Dogs.Where(x => breed != null ? x.BreedID == breed.ID : true && sex != null ? x.SexID == sex.ID : true && raceClass != null ? x.Licenses.Any(l => l.RaceClassID == raceClass.ID) : true && active ? x.Active == true : true);
        }
        public IQueryable<Dog> GetByAccount(Account account, bool active = true)
        {
            return db.Dogs.Where(x => x.Owner.AccountID == account.ID && active ? x.Active == true : true);
        }
        public IQueryable<Dog> GetByOwner(Person owner, bool active = true)
        {
            return db.Dogs.Where(x => x.OwnerID == owner.ID && active ? x.Active == true : true);
        }
        public IQueryable<Dog> GetByEvent(RaceEvent raceEvent, bool active = true)
        {
            return db.Dogs.Where(x => x.Events.Any(e => e.ID == raceEvent.ID) && active ? x.Active == true : true);
        }
        public IQueryable<Dog> GetByID(Guid id)
        {
            return db.Dogs.Where(x => x.ID == id);
        }
        public IQueryable<Dog> GetByChip(string chip)
        {
            return db.Dogs.Where(x => x.Chip == chip);
        }
        #endregion
        public async Task Save(Dog dog, bool saveChanges = true)
        {
            if (dog.ID != Guid.Empty && db.Dogs.Any(x => x.ID == dog.ID))
                db.Update(dog);
            else
            {
                if (dog.ID == Guid.Empty)
                    dog.ID = Guid.NewGuid();

                await db.AddAsync(dog);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
        public async Task Deactivate(Dog dog)
        {
            if (dog.ID != Guid.Empty && db.Dogs.Any(x => x.ID == dog.ID))
            {
                await dog.Licenses.AsQueryable().ForEachAsync(license =>
                {
                    license.IsActive = false;
                });
                dog.Active = false;
                await db.SaveChangesAsync();
            }
        }
        #region Licenses
        public async Task AddLicenses(Dog dog, List<RaceLicense> licenses, bool saveChanges = true)
        {
            if (dog.ID != Guid.Empty && db.Dogs.Any(x => x.ID == dog.ID) && !dog.Active == false)
            {
                await licenses.AsQueryable().ForEachAsync(async (license) =>
                {
                    if (db.Licenses.Any(l => l.DogID == dog.ID && l.RaceClass.CompetitionID == license.RaceClass.CompetitionID))
                    {
                        await ChangeClass(dog, license.RaceClass, false);
                    }
                    else
                        license.DogID = dog.ID;
                    license.IsActive = true;
                    await db.Licenses.AddAsync(license);
                });
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
        public async Task DeactivateLicense(Dog dog, RaceCompetition competition, bool saveChanges = true)
        {
            if (dog.ID != Guid.Empty && db.Dogs.Any(x => x.ID == dog.ID) && dog.Active)
            {
                var license = await db.Licenses.FirstOrDefaultAsync(l => l.DogID == dog.ID && l.RaceClass.CompetitionID == competition.ID);
                if (license != null)
                {
                    license.IsActive = false;
                    if (saveChanges)
                        await db.SaveChangesAsync();
                }
            }
        }
        public async Task ChangeClass(Dog dog, RaceClass raceClass, bool saveChanges = true)
        {
            if (dog.ID != Guid.Empty && db.Dogs.Any(x => x.ID == dog.ID) && raceClass.ID != Guid.Empty && db.RaceClasses.Any(x => x.ID == raceClass.ID) && dog.Active)
            {
                if ((await db.RaceClasses.FirstAsync(c => c.ID == raceClass.ID)).Breeds.Any(b => b.ID == dog.BreedID))
                {
                    var license = await db.Licenses.FirstOrDefaultAsync(l => l.DogID == dog.ID && l.RaceClass.CompetitionID == raceClass.CompetitionID);
                    if (license != null)
                    {
                        license.RaceClassID = raceClass.ID;
                        license.IsActive = true;
                        if (saveChanges)
                            await db.SaveChangesAsync();
                    }
                }
            }
        }
        #endregion
    }
}
