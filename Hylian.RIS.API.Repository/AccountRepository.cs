using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class AccountRepository : IAccountRepository
    {
        DbaseContext db;
        IPersonRepository _personRepository;

        public AccountRepository(DbaseContext dbContext, IPersonRepository personRepository)
        {
            db = dbContext;
            _personRepository = personRepository;
        }
        #region Get
        public IQueryable<Account> GetAll(bool activeOnly = true)
        {
            return db.Accounts.Include(x => x.Roles).ThenInclude(r => r.Role).Where(x => activeOnly ? x.Deleted == null : true);
        }
        public IQueryable<Account> GetByID(Guid id, bool activeOnly = true)
        {
            return db.Accounts.Include(x => x.Roles).ThenInclude(r => r.Role).Include(x => x.Address).ThenInclude(a => a.Country).Where(x => x.ID == id && activeOnly ? x.Deleted == null : true);
        }
        public IQueryable<Account> GetByEmail(string email, bool activeOnly = true)
        {
            return db.Accounts.Include(x => x.Roles).ThenInclude(r => r.Role).Include(x => x.Address).ThenInclude(a => a.Country).Where(x => x.Email == email && activeOnly ? x.Deleted == null : true);
        }
        public IQueryable<Account> GetByOrganisation(Organisation organisation, bool activeOnly = true)
        {
            return db.Accounts.Include(x => x.Roles).ThenInclude(r => r.Role).Include(x => x.Address).ThenInclude(a => a.Country).Where(x => x.Roles.Any(r => r.OrganisationID == organisation.ID) && activeOnly ? x.Deleted == null : true);
        }
        public IQueryable<Account> GetByRole(Role role, bool activeOnly = true)
        {
            return db.Accounts.Include(x => x.Roles).ThenInclude(r => r.Role).Include(x => x.Address).ThenInclude(a => a.Country).Where(x => x.Roles.Any(r => r.RoleID == role.ID) && activeOnly ? x.Deleted == null : true);
        }
        #endregion
        public async Task Delete(Account account)
        {
            if (account.ID != Guid.Empty && db.Accounts.Any(x => x.ID == account.ID))
            {
                account.Deleted = DateTime.UtcNow;
                db.AccountRoles.RemoveRange(db.AccountRoles.Where(r => r.AccountID == account.ID).ToArray());
                await Save(account);
            }
        }
        public async Task Anonymise(IList<Account> accounts)
        {
            await accounts.AsQueryable().ForEachAsync(async (account) =>
           {
               if (account.ID != Guid.Empty && db.Accounts.Any(x => x.ID == account.ID && x.Deleted.HasValue && !x.Anonymised.HasValue))
               {
                   account.Anonymised = DateTime.UtcNow;
                   var anonymisedText = $"Anonymised{account.Anonymised.Value.Ticks}";
                   account.FirstName = anonymisedText;
                   account.LastName = anonymisedText;
                   account.Email = anonymisedText;
                   account.Phone = anonymisedText; ;
                   account.AddressID = null;
                   await db.Persons.Where(p => p.AccountID == account.ID).ForEachAsync(p =>
                   {
                       _personRepository.Anonymise(p, false);
                   });
                   await Save(account, false);
               }
           });
            await db.SaveChangesAsync();
        }
        public async Task Save(Account account, bool saveChanges = true)
        {
            if (account.ID != Guid.Empty && db.Accounts.Any(x => x.ID == account.ID))
                db.Update(account);
            else
            {
                if (account.ID == Guid.Empty)
                    account.ID = Guid.NewGuid();

                await db.AddAsync(account);
                await AddRoles(account, new List<Role>() { new Role() { ID = Constants.UserRoleID } });
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
        #region Roles
        public async Task AddRoles(Account account, List<Role> roles, Organisation organisation = null)
        {
            if (account.ID != Guid.Empty && db.Accounts.Any(x => x.ID == account.ID) && !account.Deleted.HasValue)
            {
                organisation = organisation ?? new Organisation() { ID = Constants.SystemOrganisationID };
                await roles.AsQueryable().ForEachAsync(async (role) =>
                {
                    await db.AccountRoles.AddAsync(new AccountRole()
                    {
                        AccountID = account.ID,
                        RoleID = role.ID,
                        OrganisationID = organisation.ID
                    });
                });
            }
            await db.SaveChangesAsync();
        }
        public async Task RemoveRoles(Account account, bool ban = false)
        {
            if (account.ID != Guid.Empty && db.Accounts.Any(x => x.ID == account.ID) && !account.Deleted.HasValue)
            {
                db.AccountRoles.RemoveRange(db.AccountRoles.Where(r => r.AccountID == account.ID && ban ? true : r.RoleID != Constants.UserRoleID).ToList());
                await db.SaveChangesAsync();
            }
        }
        public async Task RemoveRoles(Account account, Organisation organisation = null, bool ban = false)
        {
            if (account.ID != Guid.Empty && db.Accounts.Any(x => x.ID == account.ID) && !account.Deleted.HasValue)
            {
                organisation = organisation ?? new Organisation() { ID = Constants.SystemOrganisationID };
                db.AccountRoles.RemoveRange(db.AccountRoles.Where(r => r.AccountID == account.ID && r.OrganisationID == organisation.ID && ban ? true : r.RoleID != Constants.UserRoleID).ToList());
                await db.SaveChangesAsync();
            }
        }
        public async Task RemoveRoles(Account account, List<Role> roles, Organisation organisation = null)
        {
            if (account.ID != Guid.Empty && db.Accounts.Any(x => x.ID == account.ID) && !account.Deleted.HasValue)
            {
                if (account.ID != Guid.Empty && db.Accounts.Any(x => x.ID == account.ID) && !account.Deleted.HasValue)
                {
                    organisation = organisation ?? new Organisation() { ID = Constants.SystemOrganisationID };
                    await roles.AsQueryable().ForEachAsync(async (role) =>
                    {
                        var accountRole = await db.AccountRoles.FirstOrDefaultAsync(r =>
                            r.AccountID == account.ID &&
                            r.RoleID == role.ID &&
                            r.OrganisationID == organisation.ID
                        );
                        if (accountRole != null)
                            db.AccountRoles.Remove(accountRole);
                    });
                }
                await db.SaveChangesAsync();
            }
        }
        #endregion
    }
}
