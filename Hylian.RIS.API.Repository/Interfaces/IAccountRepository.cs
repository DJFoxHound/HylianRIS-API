using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IAccountRepository
    {
        Task AddRoles(Account account, List<Role> roles, Organisation organisation = null);
        Task Anonymise(IList<Account> accounts);
        Task Delete(Account account);
        IQueryable<Account> GetAll(bool activeOnly = true);
        IQueryable<Account> GetByEmail(string email, bool activeOnly = true);
        IQueryable<Account> GetByID(Guid id, bool activeOnly = true);
        IQueryable<Account> GetByOrganisation(Organisation organisation, bool activeOnly = true);
        IQueryable<Account> GetByRole(Role role, bool activeOnly = true);
        Task RemoveRoles(Account account, bool ban = false);
        Task RemoveRoles(Account account, Organisation organisation = null, bool ban = false);
        Task RemoveRoles(Account account, List<Role> roles, Organisation organisation = null);
        Task Save(Account account, bool saveChanges = true);
    }
}