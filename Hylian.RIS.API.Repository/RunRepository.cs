using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class RunRepository : IRunRepository
    {
        DbaseContext db;
        ITrackRecordRepository _trackRecorsRepository;

        public RunRepository(DbaseContext dbContext, ITrackRecordRepository trackRecorsRepository)
        {
            db = dbContext;
            _trackRecorsRepository = trackRecorsRepository;
        }
        #region Get
        public IQueryable<Run> GetAll()
        {
            return db.Runs.Include(x => x.Dog).ThenInclude(d => d.Owner).ThenInclude(o => o.Country).Include(x => x.Dog).ThenInclude(d => d.Country).Include(x => x.Jersey).Include(x => x.Race).ThenInclude(r => r.Breed).Include(x => x.Race).ThenInclude(r => r.Sex).Include(x => x.Race).ThenInclude(r => r.Class).Include(x => x.Race).ThenInclude(r => r.Distance).OrderBy(x => x.Race.Event.Date).ThenBy(x => x.Race.EventID).ThenBy(x => x.Race.OrderNr).ThenBy(x => x.ResultOrder);
        }
        public IQueryable<Run> GetByRace(Race race)
        {
            return db.Runs.Include(x => x.Dog).ThenInclude(d => d.Owner).ThenInclude(o => o.Country).Include(x => x.Dog).ThenInclude(d => d.Country).Include(x => x.Jersey).Include(x => x.Race).ThenInclude(r => r.Breed).Include(x => x.Race).ThenInclude(r => r.Sex).Include(x => x.Race).ThenInclude(r => r.Class).Include(x => x.Race).ThenInclude(r => r.Distance).Where(x => x.RaceID == race.ID).OrderBy(x => x.ResultOrder);
        }
        public IQueryable<Run> GetByDog(Dog dog)
        {
            return db.Runs.Include(x => x.Dog).ThenInclude(d => d.Owner).ThenInclude(o => o.Country).Include(x => x.Dog).ThenInclude(d => d.Country).Include(x => x.Jersey).Include(x => x.Race).ThenInclude(r => r.Breed).Include(x => x.Race).ThenInclude(r => r.Sex).Include(x => x.Race).ThenInclude(r => r.Class).Include(x => x.Race).ThenInclude(r => r.Distance).Where(x => x.DogID == dog.ID).OrderBy(x => x.Race.Event.Date).ThenBy(x => x.Race.EventID).ThenBy(x => x.Race.OrderNr).ThenBy(x => x.ResultOrder);
        }
        public IQueryable<Run> GetByID(Guid id)
        {
            return db.Runs.Include(x => x.Dog).ThenInclude(d => d.Owner).ThenInclude(o => o.Country).Include(x => x.Dog).ThenInclude(d => d.Country).Include(x => x.Jersey).Include(x => x.Race).ThenInclude(r => r.Breed).Include(x => x.Race).ThenInclude(r => r.Sex).Include(x => x.Race).ThenInclude(r => r.Class).Include(x => x.Race).ThenInclude(r => r.Distance).Where(x => x.ID == id);
        }
        #endregion
        public async Task Save(Run run, bool saveChanges = true)
        {
            if (run.ID != Guid.Empty && db.Runs.Any(x => x.ID == run.ID))
                db.Update(run);
            else
            {
                if (run.ID == Guid.Empty)
                    run.ID = Guid.NewGuid();
                await db.AddAsync(run);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
        /// <summary>
        /// When true, it'll also update the record!
        /// </summary>
        public async Task<bool> IsTrackRecord(Run run, RaceTrack track, bool saveChanges = true)
        {
            return await _trackRecorsRepository.IsTrackRecord(run, track, saveChanges);
        }
    }
}
