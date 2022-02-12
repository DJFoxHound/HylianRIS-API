using Hylian.RIS.API.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IJerseyRepository
    {
        Task<IList<Jersey>> GetAll();
        Task<IList<Jersey>> GetByCompetition(RaceCompetition competition);
        Task Save(Jersey jersey, bool saveChanges = true);
    }
}