using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        public async Task<IList<Sex>> GetAll()
        {
            return await db.Sexes.ToListAsync();
        }
        public async Task<Sex> GetByID(Guid id)
        {
            return await db.Sexes.FirstOrDefaultAsync(x => x.ID == id);
        }
        public async Task<Sex> GetByCode(string code)
        {
            return await db.Sexes.FirstOrDefaultAsync(x => x.Code.ToUpperInvariant() == code.ToUpperInvariant());
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
