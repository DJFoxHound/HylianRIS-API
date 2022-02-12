using Hylian.RIS.API.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IDistanceRepository
    {
        Task<IList<Distance>> GetAll(bool officialOnly = false);
        Task<IList<Distance>> GetByTrack(RaceTrack track, bool officialOnly = false);
        Task Save(Distance distance, bool saveChanges = true);
    }
}