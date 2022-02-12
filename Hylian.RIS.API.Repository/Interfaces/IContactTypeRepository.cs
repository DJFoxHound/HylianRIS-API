using Hylian.RIS.API.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IContactTypeRepository
    {
        Task<IList<ContactType>> GetAll();
    }
}