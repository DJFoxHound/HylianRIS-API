using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRunRepository
    {
        Task<IList<Run>> GetAll();
        Task<IList<Run>> GetByDog(Dog dog);
        Task<Run> GetByID(Guid id);
        Task<IList<Run>> GetByRace(Race race);
        Task<bool> IsTrackRecord(Run run, RaceTrack track);
        Task Save(Run run, bool saveChanges = true);
    }
}