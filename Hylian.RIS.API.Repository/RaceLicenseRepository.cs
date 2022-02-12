using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    internal class RaceLicenseRepository : IRaceLicenseRepository
    {
        DbaseContext db;

        public RaceLicenseRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<RaceLicense>> GetAll(bool? isActive = null)
        {
            return await db.Licenses.Include(x => x.Dog).ThenInclude(d => d.Owner).Include(x => x.RaceClass).ThenInclude(c => c.Competition).Where(x => isActive.HasValue ? x.IsActive == isActive : true).ToListAsync();
        }
        public async Task<IList<RaceLicense>> GetByCompetition(RaceCompetition competition, bool? isActive = null)
        {
            return await db.Licenses.Include(x => x.Dog).ThenInclude(d => d.Owner).Include(x => x.RaceClass).ThenInclude(c => c.Competition).Where(x => x.RaceClass.CompetitionID == competition.ID && isActive.HasValue ? x.IsActive == isActive : true).ToListAsync();
        }
        public async Task<IList<RaceLicense>> GetByClass(RaceClass raceClass, bool? isActive = null)
        {
            return await db.Licenses.Include(x => x.Dog).ThenInclude(d => d.Owner).Include(x => x.RaceClass).ThenInclude(c => c.Competition).Where(x => x.RaceClassID == raceClass.ID && isActive.HasValue ? x.IsActive == isActive : true).ToListAsync();
        }
        public async Task<IList<RaceLicense>> GetByBreed(Breed breed, RaceCompetition competition = null, bool? isActive = null)
        {
            return await db.Licenses.Include(x => x.Dog).ThenInclude(d => d.Owner).Include(x => x.RaceClass).ThenInclude(c => c.Competition).Where(x => x.Dog.BreedID == breed.ID && competition != null ? x.RaceClass.CompetitionID == competition.ID : true && isActive.HasValue ? x.IsActive == isActive : true).ToListAsync();
        }
        public async Task<IList<RaceLicense>> GetByDog(Dog dog, bool? isActive = null)
        {
            return await db.Licenses.Include(x => x.Dog).ThenInclude(d => d.Owner).Include(x => x.RaceClass).ThenInclude(c => c.Competition).Where(x => x.Dog.ID == dog.ID && isActive.HasValue ? x.IsActive == isActive : true).ToListAsync();
        }
        public async Task<RaceLicense> GetByID(Guid id)
        {
            return await db.Licenses.FirstOrDefaultAsync(x => x.ID == id);
        }
        public async Task<IList<RaceLicense>> GetByLicenseNumber(string licenseNumber, RaceCompetition competition = null, bool? isActive = null)
        {
            return await db.Licenses.Include(x => x.Dog).ThenInclude(d => d.Owner).Include(x => x.RaceClass).ThenInclude(c => c.Competition).Where(x => x.LicenseNumber.ToLowerInvariant() == licenseNumber.ToLowerInvariant() && competition != null ? x.RaceClass.CompetitionID == competition.ID : true && isActive.HasValue ? x.IsActive == isActive : true).ToListAsync();
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
