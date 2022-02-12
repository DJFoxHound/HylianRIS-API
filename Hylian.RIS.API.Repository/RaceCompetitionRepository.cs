using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        public async Task<IList<RaceCompetition>> GetAll(bool? isProffesional = null)
        {
            return await db.Competitions.Where(x => isProffesional.HasValue ? x.IsProfessional == isProffesional : true).ToListAsync();
        }
        public async Task<RaceCompetition> GetByID(Guid id)
        {
            return await db.Competitions.FirstOrDefaultAsync(x => x.ID == id);
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
