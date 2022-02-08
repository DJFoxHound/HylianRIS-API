using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceEventRepository
    {
        Task Delete(RaceEvent raceEvent, bool saveChanges = true);
        IQueryable<RaceEvent> GetAll(DateTime? from = null, DateTime? until = null, bool? isOfficial = false, RaceCompetition competition = null, bool includeDeleted = false);
        IQueryable<RaceEvent> GetByAccount(Account account, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, RaceCompetition competition = null, bool includeDeleted = false);
        IQueryable<RaceEvent> GetByCountry(Country country, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, bool includeDeleted = false);
        IQueryable<RaceEvent> GetByDog(Dog dog, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, RaceCompetition competition = null, bool includeDeleted = false);
        IQueryable<RaceEvent> GetByID(Guid id);
        IQueryable<RaceEvent> GetByOrganisation(Organisation organisation, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, bool includeDeleted = false);
        IQueryable<RaceEvent> GetByPerson(Account account, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, RaceCompetition competition = null, bool includeDeleted = false);
        IQueryable<RaceEvent> GetByTrack(RaceTrack track, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, bool includeDeleted = false);
        Task Save(RaceEvent raceEvent, bool saveChanges = true);
    }
}