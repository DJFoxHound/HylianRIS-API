using Hylian.RIS.API.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface ICrewTypeRepository
    {
        Task<IList<CrewType>> GetAll();
    }
}