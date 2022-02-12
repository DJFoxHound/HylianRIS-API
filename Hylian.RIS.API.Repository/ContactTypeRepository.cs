using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    internal class ContactTypeRepository : IContactTypeRepository
    {
        DbaseContext db;

        public ContactTypeRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<ContactType>> GetAll()
        {
            return await db.ContactTypes.ToListAsync();
        }
        #endregion
    }
}
