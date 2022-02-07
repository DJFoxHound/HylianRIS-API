using Hylian.RIS.API.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IJerseyRepository
    {
        IQueryable<Jersey> GetAll();
        IQueryable<Jersey> GetByCompetition(RaceCompetition competition);
        Task Save(Jersey jersey, bool saveChanges = true);
    }
}