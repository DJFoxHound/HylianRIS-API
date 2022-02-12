using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        public async Task<IList<TrackRecord>> GetAll()
        {
            return await db.TrackRecords.Include(x => x.Run).ThenInclude(r => r.Dog).Include(x => x.Breed).Include(d => d.Sex).Include(x => x.Distance).Include(x => x.Track).OrderBy(x => x.Track.Name).ThenBy(x => x.Distance.Length).ThenBy(x => x.Breed.Names.FirstOrDefault(n => n.LanguageCode == "en")).ThenBy(x => x.Sex.Code).ToListAsync();
        }
        public async Task<IList<TrackRecord>> GetByTrack(RaceTrack track)
        {
            return await db.TrackRecords.Include(x => x.Run).ThenInclude(r => r.Dog).Include(x => x.Breed).Include(d => d.Sex).Include(x => x.Distance).Include(x => x.Track).Where(x => x.TrackID == track.ID).OrderBy(x => x.Track.Name).ThenBy(x => x.Distance.Length).ThenBy(x => x.Breed.Names.FirstOrDefault(n => n.LanguageCode == "en")).ThenBy(x => x.Sex.Code).ToListAsync();
        }
        public async Task<IList<TrackRecord>> GetByBreed(Breed breed, Sex sex = null)
        {
            return await db.TrackRecords.Include(x => x.Run).ThenInclude(r => r.Dog).Include(x => x.Breed).Include(d => d.Sex).Include(x => x.Distance).Include(x => x.Track).Where(x => x.BreedID == breed.ID && sex != null ? x.SexID == sex.ID : true).OrderBy(x => x.Track.Name).ThenBy(x => x.Distance.Length).ThenBy(x => x.Breed.Names.FirstOrDefault(n => n.LanguageCode == "en")).ThenBy(x => x.Sex.Code).ToListAsync();
        }
        public async Task<IList<TrackRecord>> GetByDog(Dog dog)
        {
            return await db.TrackRecords.Include(x => x.Run).ThenInclude(r => r.Dog).Include(x => x.Breed).Include(d => d.Sex).Include(x => x.Distance).Include(x => x.Track).Where(x => x.Run.DogID == dog.ID).OrderBy(x => x.Track.Name).ThenBy(x => x.Distance.Length).ThenBy(x => x.Breed.Names.FirstOrDefault(n => n.LanguageCode == "en")).ThenBy(x => x.Sex.Code).ToListAsync();
        }
        public async Task<IList<TrackRecord>> GetByDistance(Distance distance)
        {
            return await db.TrackRecords.Include(x => x.Run).ThenInclude(r => r.Dog).Include(x => x.Breed).Include(d => d.Sex).Include(x => x.Distance).Include(x => x.Track).Where(x => x.DistanceID == distance.ID).OrderBy(x => x.Track.Name).ThenBy(x => x.Distance.Length).ThenBy(x => x.Breed.Names.FirstOrDefault(n => n.LanguageCode == "en")).ThenBy(x => x.Sex.Code).ToListAsync();
        }
        public async Task<TrackRecord> GetByID(Guid id)
        {
            return await db.TrackRecords.Include(x => x.Run).ThenInclude(r => r.Dog).Include(x => x.Breed).Include(d => d.Sex).Include(x => x.Distance).Include(x => x.Track).FirstOrDefaultAsync(x => x.ID == id);
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
        public async Task<bool> IsTrackRecord(Run run, RaceTrack track)
        {
            if (run.ID != Guid.Empty && db.Runs.Any(x => x.ID == run.ID && x.Race.RaceType.IsOfficial) && run.TimeTicks.HasValue)
            {
                var record = await db.TrackRecords.FirstOrDefaultAsync(x => x.TrackID == track.ID && x.BreedID == run.Dog.BreedID && x.SexID == run.Dog.SexID && x.DistanceID == run.Race.DistanceID);
                if (record == null || record.TimeTicks > run.TimeTicks)
                    return true;
            }
            return false;
        }
    }
}
