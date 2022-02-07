using Hylian.RIS.API.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IDistanceRepository
    {
        IQueryable<Distance> GetAll(bool officialOnly = false);
        IQueryable<Distance> GetByTrack(RaceTrack track, bool officialOnly = false);
        Task Save(Distance distance, bool saveChanges = true);
    }
}