using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface ITrackSurfaceRepository
    {
        Task<IList<TrackSurface>> GetAll();
        Task<TrackSurface> GetByID(Guid id);
        Task Save(TrackSurface TrackSurface, bool saveChanges = true);
    }
}