using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class TrackRecordRepository : ITrackRecordRepository
    {
        DbaseContext db;

        public TrackRecordRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<TrackRecord> GetAll()
        {
            return db.TrackRecords.Include(x => x.Run).ThenInclude(r => r.Dog).Include(x => x.Breed).Include(d => d.Sex).Include(x => x.Distance).Include(x => x.Track).OrderBy(x => x.Track.Name).ThenBy(x => x.Distance.Length).ThenBy(x => x.Breed.Names.FirstOrDefault(n => n.LanguageCode == "en")).ThenBy(x => x.Sex.Code);
        }
        public IQueryable<TrackRecord> GetByTrack(RaceTrack track)
        {
            return db.TrackRecords.Include(x => x.Run).ThenInclude(r => r.Dog).Include(x => x.Breed).Include(d => d.Sex).Include(x => x.Distance).Include(x => x.Track).Where(x => x.TrackID == track.ID).OrderBy(x => x.Track.Name).ThenBy(x => x.Distance.Length).ThenBy(x => x.Breed.Names.FirstOrDefault(n => n.LanguageCode == "en")).ThenBy(x => x.Sex.Code);
        }
        public IQueryable<TrackRecord> GetByBreed(Breed breed, Sex sex = null)
        {
            return db.TrackRecords.Include(x => x.Run).ThenInclude(r => r.Dog).Include(x => x.Breed).Include(d => d.Sex).Include(x => x.Distance).Include(x => x.Track).Where(x => x.BreedID == breed.ID && sex != null ? x.SexID == sex.ID : true).OrderBy(x => x.Track.Name).ThenBy(x => x.Distance.Length).ThenBy(x => x.Breed.Names.FirstOrDefault(n => n.LanguageCode == "en")).ThenBy(x => x.Sex.Code);
        }
        public IQueryable<TrackRecord> GetByDog(Dog dog)
        {
            return db.TrackRecords.Include(x => x.Run).ThenInclude(r => r.Dog).Include(x => x.Breed).Include(d => d.Sex).Include(x => x.Distance).Include(x => x.Track).Where(x => x.Run.DogID == dog.ID).OrderBy(x => x.Track.Name).ThenBy(x => x.Distance.Length).ThenBy(x => x.Breed.Names.FirstOrDefault(n => n.LanguageCode == "en")).ThenBy(x => x.Sex.Code);
        }
        public IQueryable<TrackRecord> GetByDistance(Distance distance)
        {
            return db.TrackRecords.Include(x => x.Run).ThenInclude(r => r.Dog).Include(x => x.Breed).Include(d => d.Sex).Include(x => x.Distance).Include(x => x.Track).Where(x => x.DistanceID == distance.ID).OrderBy(x => x.Track.Name).ThenBy(x => x.Distance.Length).ThenBy(x => x.Breed.Names.FirstOrDefault(n => n.LanguageCode == "en")).ThenBy(x => x.Sex.Code);
        }
        public IQueryable<TrackRecord> GetByID(Guid id)
        {
            return db.TrackRecords.Include(x => x.Run).ThenInclude(r => r.Dog).Include(x => x.Breed).Include(d => d.Sex).Include(x => x.Distance).Include(x => x.Track).Where(x => x.ID == id);
        }
        #endregion
        public async Task Save(TrackRecord record, bool saveChanges = true)
        {
            if (record.ID != Guid.Empty && db.TrackRecords.Any(x => x.ID == record.ID))
                db.Update(record);
            else
            {
                if (record.ID == Guid.Empty)
                    record.ID = Guid.NewGuid();
                await db.AddAsync(record);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
        /// <summary>
        /// When true, it'll also update the record!
        /// </summary>
        public async Task<bool> IsTrackRecord(Run run, RaceTrack track, bool saveChanges = true)
        {
            if (run.ID != Guid.Empty && db.Runs.Any(x => x.ID == run.ID && x.Race.RaceType.IsOfficial) && run.TimeTicks.HasValue)
            {
                var record = await db.TrackRecords.FirstOrDefaultAsync(x => x.TrackID == track.ID && x.BreedID == run.Dog.BreedID && x.SexID == run.Dog.SexID && x.DistanceID == run.Race.DistanceID);
                if (record == null)
                {
                    record = new TrackRecord() { ID = Guid.NewGuid(), RunID = run.ID, BreedID = run.Dog.BreedID, SexID = run.Dog.SexID, DogName = run.Dog.Name, DistanceID = run.Race.DistanceID, TrackID = track.ID };
                }
                else if (record.TimeTicks > run.TimeTicks)
                {
                    record.TimeTicks = run.TimeTicks.Value;
                    record.RunID = run.ID;
                    record.Date = run.Race.Event.Date;
                    record.DogName = run.Dog.Name;
                    record.IsPreSystem = false;
                }
                else
                {
                    return false;
                }
                await Save(record, false);
                if (saveChanges)
                    await db.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
