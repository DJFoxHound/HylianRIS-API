using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using System;
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
        public IQueryable<RaceType> GetAll(bool? isOfficial = null)
        {
            return db.RaceTypes.Where(x => isOfficial.HasValue ? x.IsOfficial == isOfficial : true);
        }
        public IQueryable<RaceType> GetByCompetition(RaceCompetition competition, bool? isOfficial = null)
        {
            return db.RaceTypes.Where(x => x.Competitions.Any(c => c.ID == competition.ID) && isOfficial.HasValue ? x.IsOfficial == isOfficial : true);
        }
        public IQueryable<RaceType> GetByID(Guid id)
        {
            return db.RaceTypes.Where(x => x.ID == id);
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
