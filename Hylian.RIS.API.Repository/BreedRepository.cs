using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class BreedRepository : IBreedRepository
    {
        DbaseContext db;

        public BreedRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<Breed>> GetAll()
        {
            return await db.Breeds.ToListAsync();
        }
        public async Task<Breed> GetByID(Guid id)
        {
            return await db.Breeds.FirstOrDefaultAsync(x => x.ID == id);
        }
        public async Task<IList<Breed>> GetByCompetition(RaceCompetition competition)
        {
            return await db.Breeds.Include(x => x.AgeRestrictions.Where(a => a.CompetitionID == competition.ID)).Include(x => x.Classes.Where(c => c.CompetitionID == competition.ID)).Where(x => x.AgeRestrictions.Any(a => a.CompetitionID == competition.ID) || x.Classes.Any(c => c.CompetitionID == competition.ID)).ToListAsync();
        }
        #endregion
        public async Task Save(Breed breed, bool saveChanges = true)
        {
            if (breed.ID != Guid.Empty && db.Breeds.Any(x => x.ID == breed.ID))
                db.Update(breed);
            else
            {
                if (breed.ID == Guid.Empty)
                    breed.ID = Guid.NewGuid();
                await db.AddAsync(breed);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
