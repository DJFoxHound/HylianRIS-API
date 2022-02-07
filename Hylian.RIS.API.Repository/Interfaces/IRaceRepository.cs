using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceRepository
    {
        Task Delete(Race race, bool saveChanges = true);
        IQueryable<Race> GetAll(RaceCompetition competition = null);
        IQueryable<Race> GetByAccount(Account account, RaceCompetition competition = null);
        IQueryable<Race> GetByDog(Dog dog, RaceCompetition competition = null);
        IQueryable<Race> GetByEvent(RaceEvent raceEvent);
        IQueryable<Race> GetByID(Guid id);
        IQueryable<Race> GetByNumber(RaceEvent raceEvent, string number);
        IQueryable<Race> GetByTrack(RaceTrack track, RaceCompetition competition = null);
        Task Move(Race race, int newPosistion);
        Task Save(Race race, bool saveChanges = true);
    }
}