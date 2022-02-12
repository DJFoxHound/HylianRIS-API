using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceEventRepository
    {
        Task Delete(RaceEvent raceEvent, bool saveChanges = true);
        Task<IList<RaceEvent>> GetAll(DateTime? from = null, DateTime? until = null, bool? isOfficial = false, RaceCompetition competition = null, bool includeDeleted = false);
        Task<IList<RaceEvent>> GetByAccount(Account account, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, RaceCompetition competition = null, bool includeDeleted = false);
        Task<IList<RaceEvent>> GetByCountry(Country country, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, bool includeDeleted = false);
        Task<IList<RaceEvent>> GetByDog(Dog dog, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, RaceCompetition competition = null, bool includeDeleted = false);
        Task<RaceEvent> GetByID(Guid id);
        Task<IList<RaceEvent>> GetByOrganisation(Organisation organisation, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, bool includeDeleted = false);
        Task<IList<RaceEvent>> GetByPerson(Account account, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, RaceCompetition competition = null, bool includeDeleted = false);
        Task<IList<RaceEvent>> GetByTrack(RaceTrack track, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, bool includeDeleted = false);
        Task Save(RaceEvent raceEvent, bool saveChanges = true);
    }
}