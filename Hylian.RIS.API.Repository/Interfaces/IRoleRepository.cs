using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRoleRepository
    {
        Task<IList<Role>> GetAll();
        Task<IList<Role>> GetByAccount(Account account);
        Task<Role> GetByID(Guid id);
        Task<IList<Role>> GetByOrganisation(Organisation organisation);
        Task Save(Role role, bool saveChanges = true);
    }
}