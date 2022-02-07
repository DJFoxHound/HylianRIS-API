using Hylian.RIS.API.Domain;
using System.Linq;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IContactTypeRepository
    {
        IQueryable<ContactType> GetAll();
    }
}