using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    internal class RoleRepository : IRoleRepository
    {
        DbaseContext db;

        public RoleRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<Role>> GetAll()
        {
            return await db.Roles.ToListAsync();
        }
        public async Task<IList<Role>> GetByOrganisation(Organisation organisation)
        {
            return await db.Roles.Where(x => x.Accounts.Any(a => a.OrganisationID == organisation.ID)).ToListAsync();
        }
        public async Task<IList<Role>> GetByAccount(Account account)
        {
            return await db.Roles.Where(x => x.Accounts.Any(a => a.AccountID == account.ID)).ToListAsync();
        }
        public async Task<Role> GetByID(Guid id)
        {
            return await db.Roles.FirstOrDefaultAsync(x => x.ID == id);
        }
        #endregion
        public async Task Save(Role role, bool saveChanges = true)
        {
            if (role.ID != Guid.Empty && db.Roles.Any(x => x.ID == role.ID))
                db.Update(role);
            else
            {
                if (role.ID == Guid.Empty)
                    role.ID = Guid.NewGuid();
                await db.AddAsync(role);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
