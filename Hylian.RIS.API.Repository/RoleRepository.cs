using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class RoleRepository : IRoleRepository
    {
        DbaseContext db;

        public RoleRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<Role> GetAll()
        {
            return db.Roles;
        }
        public IQueryable<Role> GetByOrganisation(Organisation organisation)
        {
            return db.Roles.Where(x => x.Accounts.Any(a => a.OrganisationID == organisation.ID));
        }
        public IQueryable<Role> GetByAccount(Account account)
        {
            return db.Roles.Where(x => x.Accounts.Any(a => a.AccountID == account.ID));
        }
        public IQueryable<Role> GetByID(Guid id)
        {
            return db.Roles.Where(x => x.ID == id);
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
