using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class RunResultTypeRepository : IRunResultTypeRepository
    {
        DbaseContext db;

        public RunResultTypeRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<RunResultType>> GetAll()
        {
            return await db.RunResultTypes.ToListAsync();
        }
        public async Task<RunResultType> GetByID(Guid id)
        {
            return await db.RunResultTypes.FirstOrDefaultAsync(x => x.ID == id);
        }
        public async Task<RunResultType> GetByCode(string code)
        {
            return await db.RunResultTypes.FirstOrDefaultAsync(x => x.Code.ToUpperInvariant() == code.ToUpperInvariant());
        }
        #endregion
        public async Task Save(RunResultType runResultType, bool saveChanges = true)
        {
            if (runResultType.ID != Guid.Empty && db.RunResultTypes.Any(x => x.ID == runResultType.ID))
                db.Update(runResultType);
            else
            {
                if (runResultType.ID == Guid.Empty)
                    runResultType.ID = Guid.NewGuid();
                await db.AddAsync(runResultType);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
