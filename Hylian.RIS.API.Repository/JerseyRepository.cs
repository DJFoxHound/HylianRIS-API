using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class JerseyRepository : IJerseyRepository
    {
        DbaseContext db;

        public JerseyRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<Jersey> GetAll()
        {
            return db.Jerseys.Include(x => x.CompetitionID);
        }
        public IQueryable<Jersey> GetByCompetition(RaceCompetition competition)
        {
            return db.Jerseys.Where(x => x.CompetitionID == competition.ID);
        }
        #endregion
        public async Task Save(Jersey jersey, bool saveChanges = true)
        {
            if (db.Jerseys.Any(x => (x.ID == jersey.ID) || (x.Number == jersey.Number && x.CompetitionID == jersey.CompetitionID)))
                db.Update(jersey);
            else
            {
                if (jersey.ID == Guid.Empty)
                    jersey.ID = Guid.NewGuid();
                await db.AddAsync(jersey);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
