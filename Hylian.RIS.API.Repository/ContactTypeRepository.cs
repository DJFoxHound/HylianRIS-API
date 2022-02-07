using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;

using System.Linq;

namespace Hylian.RIS.API.Repository
{
    public class ContactTypeRepository : IContactTypeRepository
    {
        DbaseContext db;

        public ContactTypeRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<ContactType> GetAll()
        {
            return db.ContactTypes;
        }
        #endregion
    }
}
