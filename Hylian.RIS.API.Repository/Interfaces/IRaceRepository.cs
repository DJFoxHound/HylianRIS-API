using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceRepository
    {
        Task Delete(Race race, bool saveChanges = true);
        Task<IList<Race>> GetAll(RaceCompetition competition = null);
        Task<IList<Race>> GetByAccount(Account account, RaceCompetition competition = null);
        Task<IList<Race>> GetByDog(Dog dog, RaceCompetition competition = null);
        Task<IList<Race>> GetByEvent(RaceEvent raceEvent);
        Task<Race> GetByID(Guid id);
        Task<Race> GetByNumber(RaceEvent raceEvent, string number);
        Task<IList<Race>> GetByTrack(RaceTrack track, RaceCompetition competition = null);
        Task Move(Race race, int newPosistion);
        Task Save(Race race, bool saveChanges = true);
    }
}