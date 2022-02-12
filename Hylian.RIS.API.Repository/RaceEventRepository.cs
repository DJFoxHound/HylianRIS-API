using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class RaceEventRepository : IRaceEventRepository
    {
        DbaseContext db;

        public RaceEventRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<RaceEvent>> GetAll(DateTime? from = null, DateTime? until = null, bool? isOfficial = false, RaceCompetition competition = null, bool includeDeleted = false)
        {
            return await db.Events.Include(x => x.Competition).Include(x => x.Organisation).Include(x => x.Track).ThenInclude(t => t.Address).ThenInclude(a => a.Country).Where(x => from.HasValue ? x.Date.Date >= from.Value.Date : true && until.HasValue ? x.Date.Date <= until.Value.Date : true && isOfficial.HasValue ? x.IsOfficial == isOfficial : true && competition != null ? x.CompetitionID == competition.ID : true && includeDeleted ? true : !x.Deleted.HasValue).OrderBy(x => x.Date).ToListAsync();
        }
        public async Task<IList<RaceEvent>> GetByTrack(RaceTrack track, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, bool includeDeleted = false)
        {
            return await db.Events.Include(x => x.Competition).Include(x => x.Organisation).Include(x => x.Track).ThenInclude(t => t.Address).ThenInclude(a => a.Country).Where(x => x.TrackID == track.ID && from.HasValue ? x.Date.Date >= from.Value.Date : true && until.HasValue ? x.Date.Date <= until.Value.Date : true && isOfficial.HasValue ? x.IsOfficial == isOfficial : true && includeDeleted ? true : !x.Deleted.HasValue).OrderBy(x => x.Date).ToListAsync();
        }
        public async Task<IList<RaceEvent>> GetByCountry(Country country, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, bool includeDeleted = false)
        {
            return await db.Events.Include(x => x.Competition).Include(x => x.Organisation).Include(x => x.Track).ThenInclude(t => t.Address).ThenInclude(a => a.Country).Where(x => x.Track.Address.CountryID == country.ID && from.HasValue ? x.Date.Date >= from.Value.Date : true && until.HasValue ? x.Date.Date <= until.Value.Date : true && isOfficial.HasValue ? x.IsOfficial == isOfficial : true && includeDeleted ? true : !x.Deleted.HasValue).OrderBy(x => x.Date).ToListAsync();
        }
        public async Task<IList<RaceEvent>> GetByOrganisation(Organisation organisation, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, bool includeDeleted = false)
        {
            return await db.Events.Include(x => x.Competition).Include(x => x.Organisation).Include(x => x.Track).ThenInclude(t => t.Address).ThenInclude(a => a.Country).Where(x => x.OrganisationID == organisation.ID && from.HasValue ? x.Date.Date >= from.Value.Date : true && until.HasValue ? x.Date.Date <= until.Value.Date : true && isOfficial.HasValue ? x.IsOfficial == isOfficial : true && includeDeleted ? true : !x.Deleted.HasValue).OrderBy(x => x.Date).ToListAsync();
        }
        public async Task<IList<RaceEvent>> GetByAccount(Account account, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, RaceCompetition competition = null, bool includeDeleted = false)
        {
            return await db.Events.Include(x => x.Competition).Include(x => x.Organisation).Include(x => x.Track).ThenInclude(t => t.Address).ThenInclude(a => a.Country).Where(x => (x.Participants.Any(p => p.Owner.AccountID == account.ID) || x.Crew.Any(c => c.Person.AccountID == account.ID) || x.Delegates.Any(d => d.AccountID == account.ID)) && from.HasValue ? x.Date.Date >= from.Value.Date : true && until.HasValue ? x.Date.Date <= until.Value.Date : true && isOfficial.HasValue ? x.IsOfficial == isOfficial : true && competition == null ? x.CompetitionID == competition.ID : true && includeDeleted ? true : !x.Deleted.HasValue).OrderBy(x => x.Date).ToListAsync();
        }
        public async Task<IList<RaceEvent>> GetByPerson(Account account, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, RaceCompetition competition = null, bool includeDeleted = false)
        {
            return await db.Events.Include(x => x.Competition).Include(x => x.Organisation).Include(x => x.Track).ThenInclude(t => t.Address).ThenInclude(a => a.Country).Where(x => (x.Participants.Any(p => p.Owner.AccountID == account.ID) || x.Crew.Any(c => c.Person.AccountID == account.ID) || x.Delegates.Any(d => d.AccountID == account.ID)) && from.HasValue ? x.Date.Date >= from.Value.Date : true && until.HasValue ? x.Date.Date <= until.Value.Date : true && isOfficial.HasValue ? x.IsOfficial == isOfficial : true && competition == null ? x.CompetitionID == competition.ID : true && includeDeleted ? true : !x.Deleted.HasValue).OrderBy(x => x.Date).ToListAsync();
        }
        public async Task<IList<RaceEvent>> GetByDog(Dog dog, DateTime? from = null, DateTime? until = null, bool? isOfficial = false, RaceCompetition competition = null, bool includeDeleted = false)
        {
            return await db.Events.Include(x => x.Competition).Include(x => x.Organisation).Include(x => x.Track).ThenInclude(t => t.Address).ThenInclude(a => a.Country).Where(x => x.Participants.Any(p => p.ID == dog.ID) && from.HasValue ? x.Date.Date >= from.Value.Date : true && until.HasValue ? x.Date.Date <= until.Value.Date : true && isOfficial.HasValue ? x.IsOfficial == isOfficial : true && competition == null ? x.CompetitionID == competition.ID : true && includeDeleted ? true : !x.Deleted.HasValue).OrderBy(x => x.Date).ToListAsync();
        }
        public async Task<RaceEvent> GetByID(Guid id)
        {
            return await db.Events.Include(x => x.Competition).Include(x => x.Organisation).Include(x => x.Track).ThenInclude(t => t.Address).ThenInclude(a => a.Country).FirstOrDefaultAsync(x => x.ID == id);
        }
        #endregion
        public async Task Save(RaceEvent raceEvent, bool saveChanges = true)
        {
            if (raceEvent.ID != Guid.Empty && db.Events.Any(x => x.ID == raceEvent.ID))
                db.Update(raceEvent);
            else
            {
                if (raceEvent.ID == Guid.Empty)
                    raceEvent.ID = Guid.NewGuid();
                await db.AddAsync(raceEvent);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
        public async Task Delete(RaceEvent raceEvent, bool saveChanges = true)
        {
            if (raceEvent.ID != Guid.Empty && db.Events.Any(x => x.ID == raceEvent.ID))
            {
                raceEvent.Deleted = DateTime.UtcNow;
                await Save(raceEvent, false);
                if (saveChanges)
                    await db.SaveChangesAsync();
            }
        }
    }
}
