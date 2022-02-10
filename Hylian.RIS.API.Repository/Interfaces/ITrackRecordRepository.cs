using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface ITrackRecordRepository
    {
        IQueryable<TrackRecord> GetAll();
        IQueryable<TrackRecord> GetByBreed(Breed breed, Sex sex = null);
        IQueryable<TrackRecord> GetByDistance(Distance distance);
        IQueryable<TrackRecord> GetByDog(Dog dog);
        IQueryable<TrackRecord> GetByID(Guid id);
        IQueryable<TrackRecord> GetByTrack(RaceTrack track);
        Task<bool> IsTrackRecord(Run run, RaceTrack track, bool saveChanges = true);
        Task Save(TrackRecord record, bool saveChanges = true);
    }
}