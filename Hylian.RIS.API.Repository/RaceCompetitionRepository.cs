using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class RaceCompetitionRepository : IRaceCompetitionRepository
    {
        DbaseContext db;

        public RaceCompetitionRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<RaceCompetition> GetAll(bool? isProffesional = null)
        {
            return db.Competitions.Where(x => isProffesional == null ? x.IsProfessional == isProffesional : true);
        }
        public IQueryable<RaceCompetition> GetByID(Guid id)
        {
            return db.Competitions.Where(x => x.ID == id);
        }
        #endregion
        public async Task Save(RaceCompetition competition, bool saveChanges = true)
        {
            if (competition.ID != Guid.Empty && db.Competitions.Any(x => x.ID == competition.ID))
                db.Update(competition);
            else
            {
                if (competition.ID == Guid.Empty)
                    competition.ID = Guid.NewGuid();
                await db.AddAsync(competition);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
