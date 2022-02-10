using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRoleRepository
    {
        IQueryable<Role> GetAll();
        IQueryable<Role> GetByAccount(Account account);
        IQueryable<Role> GetByID(Guid id);
        IQueryable<Role> GetByOrganisation(Organisation organisation);
        Task Save(Role role, bool saveChanges = true);
    }
}