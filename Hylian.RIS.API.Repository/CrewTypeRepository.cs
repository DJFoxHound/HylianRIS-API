using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;

using System.Linq;

namespace Hylian.RIS.API.Repository
{
    public class CrewTypeRepository : ICrewTypeRepository
    {
        DbaseContext db;

        public CrewTypeRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<CrewType> GetAll()
        {
            return db.CrewTypes;
        }
        #endregion
    }
}
