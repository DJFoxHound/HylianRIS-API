using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    internal class AgeRestrictionRepository : IAgeRestrictionRepository
    {
        DbaseContext db;

        public AgeRestrictionRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<AgeRestriction>> GetAll()
        {
            return await db.AgeRestrictions.Include(x => x.Breed).Include(x => x.CompetitionID).ToListAsync();
        }
        public async Task<IList<AgeRestriction>> GetByBreed(Breed breed)
        {
            return await db.AgeRestrictions.Include(x => x.Breed).Include(x => x.CompetitionID).Where(x => x.BreedID == breed.ID).ToListAsync();
        }
        public async Task<IList<AgeRestriction>> GetByCompetition(RaceCompetition competition)
        {
            return await db.AgeRestrictions.Include(x => x.Breed).Include(x => x.CompetitionID).Where(x => x.CompetitionID == competition.ID).ToListAsync();
        }
        #endregion
        public async Task Save(AgeRestriction ageRestriction, bool saveChanges = true)
        {
            if (db.AgeRestrictions.Any(x => x.BreedID == ageRestriction.BreedID && x.CompetitionID == ageRestriction.CompetitionID))
                db.Update(ageRestriction);
            else
            {
                await db.AddAsync(ageRestriction);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
