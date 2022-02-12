using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        public async Task<IList<TrackSurface>> GetAll()
        {
            return await db.TrackSurfaces.ToListAsync();
        }
        public async Task<TrackSurface> GetByID(Guid id)
        {
            return await db.TrackSurfaces.FirstOrDefaultAsync(x => x.ID == id);
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
