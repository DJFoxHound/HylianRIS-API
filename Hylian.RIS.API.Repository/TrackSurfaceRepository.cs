using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class TrackSurfaceRepository : ITrackSurfaceRepository
    {
        DbaseContext db;

        public TrackSurfaceRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<TrackSurface> GetAll()
        {
            return db.TrackSurfaces;
        }
        public IQueryable<TrackSurface> GetByID(Guid id)
        {
            return db.TrackSurfaces.Where(x => x.ID == id);
        }
        #endregion
        public async Task Save(TrackSurface TrackSurface, bool saveChanges = true)
        {
            if (TrackSurface.ID != Guid.Empty && db.TrackSurfaces.Any(x => x.ID == TrackSurface.ID))
                db.Update(TrackSurface);
            else
            {
                if (TrackSurface.ID == Guid.Empty)
                    TrackSurface.ID = Guid.NewGuid();
                await db.AddAsync(TrackSurface);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
