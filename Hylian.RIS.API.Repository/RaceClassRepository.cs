using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    internal class RaceClassRepository : IRaceClassRepository
    {
        DbaseContext db;

        public RaceClassRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<RaceClass>> GetAll(RaceCompetition competition = null)
        {
            return await db.RaceClasses.Where(x => competition != null ? x.CompetitionID == competition.ID : true).ToListAsync();
        }
        public async Task<IList<RaceClass>> GetByBreed(Breed breed, RaceCompetition competition = null)
        {
            return await db.RaceClasses.Where(x => x.Breeds.Any(b => b.ID == breed.ID) && competition != null ? x.CompetitionID == competition.ID : true).ToListAsync();
        }
        public async Task<RaceClass> GetByID(Guid id)
        {
            return await db.RaceClasses.FirstOrDefaultAsync(x => x.ID == id);
        }
        #endregion
        public async Task Save(RaceClass raceClass, bool saveChanges = true)
        {
            if (raceClass.ID != Guid.Empty && db.RaceClasses.Any(x => x.ID == raceClass.ID))
                db.Update(raceClass);
            else
            {
                if (raceClass.ID == Guid.Empty)
                    raceClass.ID = Guid.NewGuid();
                await db.AddAsync(raceClass);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
