using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRunRepository
    {
        IQueryable<Run> GetAll();
        IQueryable<Run> GetByDog(Dog dog);
        IQueryable<Run> GetByID(Guid id);
        IQueryable<Run> GetByRace(Race race);
        Task<bool> IsTrackRecord(Run run, RaceTrack track, bool saveChanges = true);
        Task Save(Run run, bool saveChanges = true);
    }
}