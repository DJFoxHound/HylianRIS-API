using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class AgeRestrictionRepository : IAgeRestrictionRepository
    {
        DbaseContext db;

        public AgeRestrictionRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<AgeRestriction> GetAll()
        {
            return db.AgeRestrictions.Include(x => x.Breed).Include(x => x.CompetitionID);
        }
        public IQueryable<AgeRestriction> GetByBreed(Breed breed)
        {
            return db.AgeRestrictions.Include(x => x.Breed).Include(x => x.CompetitionID).Where(x => x.BreedID == breed.ID);
        }
        public IQueryable<AgeRestriction> GetByCompetition(RaceCompetition competition)
        {
            return db.AgeRestrictions.Include(x => x.Breed).Include(x => x.CompetitionID).Where(x => x.CompetitionID == competition.ID);
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
