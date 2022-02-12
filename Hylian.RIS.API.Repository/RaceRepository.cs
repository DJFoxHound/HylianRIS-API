using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    internal class RaceRepository : IRaceRepository
    {
        DbaseContext db;

        public RaceRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<Race>> GetAll(RaceCompetition competition = null)
        {
            return await db.Races.Where(x => competition != null ? x.Event.CompetitionID == competition.ID : true).OrderBy(x => x.Event.Date).ThenBy(x => x.EventID).ThenBy(x => x.OrderNr).ToListAsync();
        }
        public async Task<IList<Race>> GetByEvent(RaceEvent raceEvent)
        {
            return await db.Races.Where(x => x.EventID == raceEvent.ID).OrderBy(x => x.OrderNr).ToListAsync();
        }
        public async Task<IList<Race>> GetByTrack(RaceTrack track, RaceCompetition competition = null)
        {
            return await db.Races.Where(x => x.Event.TrackID == track.ID && competition != null ? x.Event.CompetitionID == competition.ID : true).OrderBy(x => x.Event.Date).ThenBy(x => x.EventID).ThenBy(x => x.OrderNr).ToListAsync();
        }
        public async Task<IList<Race>> GetByAccount(Account account, RaceCompetition competition = null)
        {
            return await db.Races.Where(x => x.Runs.Any(r => r.Dog.Owner.AccountID == account.ID) && competition != null ? x.Event.CompetitionID == competition.ID : true).OrderBy(x => x.Event.Date).ThenBy(x => x.EventID).ThenBy(x => x.OrderNr).ToListAsync();
        }
        public async Task<IList<Race>> GetByDog(Dog dog, RaceCompetition competition = null)
        {
            return await db.Races.Where(x => x.Runs.Any(r => r.DogID == dog.ID) && competition != null ? x.Event.CompetitionID == competition.ID : true).OrderBy(x => x.Event.Date).ThenBy(x => x.EventID).ThenBy(x => x.OrderNr).ToListAsync();
        }
        public async Task<Race> GetByID(Guid id)
        {
            return await db.Races.FirstOrDefaultAsync(x => x.ID == id);
        }
        public async Task<Race> GetByNumber(RaceEvent raceEvent, string number)
        {
            return await db.Races.FirstOrDefaultAsync(x => x.EventID == raceEvent.ID && x.Number.ToUpperInvariant() == number.ToUpperInvariant());
        }
        #endregion
        public async Task Move(Race race, int newPosistion)
        {
            if (race.OrderNr < newPosistion)
            {
                await db.Races.Where(x => x.EventID == race.EventID && x.OrderNr > race.OrderNr && x.OrderNr <= newPosistion).AsQueryable().ForEachAsync(async (otherRace) =>
                {
                    otherRace.OrderNr--;
                    await Save(otherRace, false);
                });
            }
            else
            {
                await db.Races.Where(x => x.EventID == race.EventID && x.OrderNr >= newPosistion && x.OrderNr < race.OrderNr).AsQueryable().ForEachAsync(async (otherRace) =>
                {
                    otherRace.OrderNr++;
                    await Save(otherRace, false);
                });
            }
            race.OrderNr = newPosistion;
            await Save(race);
        }
        public async Task Save(Race race, bool saveChanges = true)
        {
            if (race.ID != Guid.Empty && db.Races.Any(x => x.ID == race.ID))
                db.Update(race);
            else
            {
                if (race.ID == Guid.Empty)
                    race.ID = Guid.NewGuid();
                await db.AddAsync(race);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
        public async Task Delete(Race race, bool saveChanges = true)
        {
            if (race.ID != Guid.Empty && db.Races.Any(x => x.ID == race.ID))
            {
                db.Runs.RemoveRange(db.Runs.Where(x => x.RaceID == race.ID));
                db.Races.Remove(race);
                if (saveChanges)
                    await db.SaveChangesAsync();
            }
        }
    }
}
