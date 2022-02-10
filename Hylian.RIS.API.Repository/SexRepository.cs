using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class SexRepository : ISexRepository
    {
        DbaseContext db;

        public SexRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<Sex> GetAll()
        {
            return db.Sexes;
        }
        public IQueryable<Sex> GetByID(Guid id)
        {
            return db.Sexes.Where(x => x.ID == id);
        }
        public IQueryable<Sex> GetByCode(string code)
        {
            return db.Sexes.Where(x => x.Code.ToUpperInvariant() == code.ToUpperInvariant());
        }
        #endregion
        public async Task Save(Sex sex, bool saveChanges = true)
        {
            if (sex.ID != Guid.Empty && db.Sexes.Any(x => x.ID == sex.ID))
                db.Update(sex);
            else
            {
                if (sex.ID == Guid.Empty)
                    sex.ID = Guid.NewGuid();
                await db.AddAsync(sex);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
