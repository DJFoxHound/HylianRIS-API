using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class DistanceRepository : IDistanceRepository
    {
        DbaseContext db;

        public DistanceRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<Distance> GetAll(bool officialOnly = false)
        {
            return db.Distances.Where(x => officialOnly ? x.IsOfficial == true : true);
        }
        public IQueryable<Distance> GetByTrack(RaceTrack track, bool officialOnly = false)
        {
            return db.Distances.Where(x => x.Tracks.Any(t => t.ID == track.ID) && officialOnly ? x.IsOfficial == true : true);
        }
        #endregion
        public async Task Save(Distance distance, bool saveChanges = true)
        {
            if (distance.ID != Guid.Empty && db.Distances.Any(x => x.ID == distance.ID))
                db.Update(distance);
            else
            {
                if (distance.ID == Guid.Empty)
                    distance.ID = Guid.NewGuid();

                await db.AddAsync(distance);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
