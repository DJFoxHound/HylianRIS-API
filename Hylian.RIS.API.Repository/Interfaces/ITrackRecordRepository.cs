using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface ITrackRecordRepository
    {
        Task<IList<TrackRecord>> GetAll();
        Task<IList<TrackRecord>> GetByBreed(Breed breed, Sex sex = null);
        Task<IList<TrackRecord>> GetByDistance(Distance distance);
        Task<IList<TrackRecord>> GetByDog(Dog dog);
        Task<TrackRecord> GetByID(Guid id);
        Task<IList<TrackRecord>> GetByTrack(RaceTrack track);
        Task<bool> IsTrackRecord(Run run, RaceTrack track);
        Task Save(TrackRecord record, bool saveChanges = true);
    }
}