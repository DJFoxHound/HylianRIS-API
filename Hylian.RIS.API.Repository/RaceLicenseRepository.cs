using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class RaceLicenseRepository : IRaceLicenseRepository
    {
        DbaseContext db;

        public RaceLicenseRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<RaceLicense> GetAll(bool? isActive = null)
        {
            return db.Licenses.Include(x => x.Dog).ThenInclude(d => d.Owner).Include(x => x.RaceClass).ThenInclude(c => c.Competition).Where(x => isActive.HasValue ? x.IsActive == isActive : true);
        }
        public IQueryable<RaceLicense> GetByCompetition(RaceCompetition competition, bool? isActive = null)
        {
            return db.Licenses.Include(x => x.Dog).ThenInclude(d => d.Owner).Include(x => x.RaceClass).ThenInclude(c => c.Competition).Where(x => x.RaceClass.CompetitionID == competition.ID && isActive.HasValue ? x.IsActive == isActive : true);
        }
        public IQueryable<RaceLicense> GetByClass(RaceClass raceClass, bool? isActive = null)
        {
            return db.Licenses.Include(x => x.Dog).ThenInclude(d => d.Owner).Include(x => x.RaceClass).ThenInclude(c => c.Competition).Where(x => x.RaceClassID == raceClass.ID && isActive.HasValue ? x.IsActive == isActive : true);
        }
        public IQueryable<RaceLicense> GetByBreed(Breed breed, RaceCompetition competition = null, bool? isActive = null)
        {
            return db.Licenses.Include(x => x.Dog).ThenInclude(d => d.Owner).Include(x => x.RaceClass).ThenInclude(c => c.Competition).Where(x => x.Dog.BreedID == breed.ID && competition != null ? x.RaceClass.CompetitionID == competition.ID : true && isActive.HasValue ? x.IsActive == isActive : true);
        }
        public IQueryable<RaceLicense> GetByDog(Dog dog, bool? isActive = null)
        {
            return db.Licenses.Include(x => x.Dog).ThenInclude(d => d.Owner).Include(x => x.RaceClass).ThenInclude(c => c.Competition).Where(x => x.Dog.ID == dog.ID && isActive.HasValue ? x.IsActive == isActive : true);
        }
        public IQueryable<RaceLicense> GetByID(Guid id)
        {
            return db.Licenses.Where(x => x.ID == id);
        }
        public IQueryable<RaceLicense> GetByLicenseNumber(string licenseNumber, RaceCompetition competition = null, bool? isActive = null)
        {
            return db.Licenses.Include(x => x.Dog).ThenInclude(d => d.Owner).Include(x => x.RaceClass).ThenInclude(c => c.Competition).Where(x => x.LicenseNumber.ToLowerInvariant() == licenseNumber.ToLowerInvariant() && competition != null ? x.RaceClass.CompetitionID == competition.ID : true && isActive.HasValue ? x.IsActive == isActive : true);
        }
        #endregion
        public async Task Save(RaceLicense license, bool saveChanges = true)
        {
            if (license.ID != Guid.Empty && db.Licenses.Any(x => x.ID == license.ID))
                db.Update(license);
            else
            {
                if (license.ID == Guid.Empty)
                    license.ID = Guid.NewGuid();
                await db.AddAsync(license);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
