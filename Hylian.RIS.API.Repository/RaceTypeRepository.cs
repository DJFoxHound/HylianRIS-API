using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class RaceTypeRepository : IRaceTypeRepository
    {
        DbaseContext db;

        public RaceTypeRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<RaceType>> GetAll(bool? isOfficial = null)
        {
            return await db.RaceTypes.Where(x => isOfficial.HasValue ? x.IsOfficial == isOfficial : true).ToListAsync();
        }
        public async Task<IList<RaceType>> GetByCompetition(RaceCompetition competition, bool? isOfficial = null)
        {
            return await db.RaceTypes.Where(x => x.Competitions.Any(c => c.ID == competition.ID) && isOfficial.HasValue ? x.IsOfficial == isOfficial : true).ToListAsync();
        }
        public async Task<RaceType> GetByID(Guid id)
        {
            return await db.RaceTypes.FirstOrDefaultAsync(x => x.ID == id);
        }
        #endregion
        public async Task Save(RaceType type, bool saveChanges = true)
        {
            if (type.ID != Guid.Empty && db.RaceTypes.Any(x => x.ID == type.ID))
                db.Update(type);
            else
            {
                if (type.ID == Guid.Empty)
                    type.ID = Guid.NewGuid();
                await db.AddAsync(type);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
