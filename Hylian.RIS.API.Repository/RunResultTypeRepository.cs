using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using System;
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
        public IQueryable<RunResultType> GetAll()
        {
            return db.RunResultTypes;
        }
        public IQueryable<RunResultType> GetByID(Guid id)
        {
            return db.RunResultTypes.Where(x => x.ID == id);
        }
        public IQueryable<RunResultType> GetByCode(string code)
        {
            return db.RunResultTypes.Where(x => x.Code.ToUpperInvariant() == code.ToUpperInvariant());
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
