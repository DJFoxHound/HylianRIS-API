using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class RaceClassRepository : IRaceClassRepository
    {
        DbaseContext db;

        public RaceClassRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<RaceClass> GetAll(RaceCompetition competition = null)
        {
            return db.RaceClasses.Where(x => competition == null ? x.CompetitionID == competition.ID : true);
        }
        public IQueryable<RaceClass> GetByBreed(Breed breed, RaceCompetition competition = null)
        {
            return db.RaceClasses.Where(x => x.Breeds.Any(b => b.ID == breed.ID) && competition == null ? x.CompetitionID == competition.ID : true);
        }
        public IQueryable<RaceClass> GetByID(Guid id)
        {
            return db.RaceClasses.Where(x => x.ID == id);
        }
        #endregion
        public async Task Save(RaceClass raceClass, bool saveChanges = true)
        {
            if (raceClass.ID != Guid.Empty && db.RaceClasses.Any(x => x.ID == raceClass.ID))
                db.Update(raceClass);
            else
            {
                if (raceClass.ID == Guid.Empty)
                    raceClass.ID = Guid.NewGuid();
                await db.AddAsync(raceClass);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
