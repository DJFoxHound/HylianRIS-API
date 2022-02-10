using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface ITrackSurfaceRepository
    {
        IQueryable<TrackSurface> GetAll();
        IQueryable<TrackSurface> GetByID(Guid id);
        Task Save(TrackSurface TrackSurface, bool saveChanges = true);
    }
}