using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class RaceTrackRepository : IRaceTrackRepository
    {
        DbaseContext db;

        public RaceTrackRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<RaceTrack> GetAll(TrackSurface surface = null)
        {
            return db.RaceTracks.Include(x => x.Distances).Include(d => d.TrackRecords).Include(x => x.Organisations).ThenInclude(c => c.Competition).Where(x => surface != null ? x.SurfaceID == surface.ID : true);
        }
        public IQueryable<RaceTrack> GetByCompetition(RaceCompetition competition, TrackSurface surface = null)
        {
            return db.RaceTracks.Include(x => x.Distances).Include(d => d.TrackRecords).Include(x => x.Organisations).ThenInclude(c => c.Competition).Where(x => x.Organisations.Any(o => o.CompetitionID == competition.ID) && surface != null ? x.SurfaceID == surface.ID : true);
        }
        public IQueryable<RaceTrack> GetByOrganisation(Organisation organisation, TrackSurface surface = null)
        {
            return db.RaceTracks.Include(x => x.Distances).Include(d => d.TrackRecords).Include(x => x.Organisations).ThenInclude(c => c.Competition).Where(x => x.Organisations.Any(o => o.ID == organisation.ID) && surface != null ? x.SurfaceID == surface.ID : true);
        }
        public IQueryable<RaceTrack> GetByCountry(Country country, TrackSurface surface = null)
        {
            return db.RaceTracks.Include(x => x.Distances).Include(d => d.TrackRecords).Include(x => x.Organisations).ThenInclude(c => c.Competition).Where(x => x.Address.CountryID == country.ID && surface != null ? x.SurfaceID == surface.ID : true);
        }
        public IQueryable<RaceTrack> GetByID(Guid id)
        {
            return db.RaceTracks.Where(x => x.ID == id);
        }
        #endregion
        public async Task Save(RaceTrack track, bool saveChanges = true)
        {
            if (track.ID != Guid.Empty && db.RaceTracks.Any(x => x.ID == track.ID))
                db.Update(track);
            else
            {
                if (track.ID == Guid.Empty)
                    track.ID = Guid.NewGuid();
                await db.AddAsync(track);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
