using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    internal class CrewTypeRepository : ICrewTypeRepository
    {
        DbaseContext db;

        public CrewTypeRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<CrewType>> GetAll()
        {
            return await db.CrewTypes.ToListAsync();
        }
        #endregion
    }
}
