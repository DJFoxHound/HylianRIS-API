using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class OrganisationRepository : IOrganisationRepository
    {
        DbaseContext db;

        public OrganisationRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<Organisation> GetAll(bool active = true)
        {
            return db.Organisations.Where(x => active ? (x.LicenseExpires == null || x.LicenseExpires >= DateTime.Today) : true);
        }
        public IQueryable<Organisation> GetBy(RaceCompetition competition = null, Country country = null, bool active = true)
        {
            return db.Organisations.Where(x => competition == null ? x.CompetitionID == competition.ID : true && country == null ? x.Address.CountryID == country.ID : true && active ? (x.LicenseExpires == null || x.LicenseExpires >= DateTime.Today) : true);
        }
        public IQueryable<Organisation> GetByTrack(RaceTrack track, bool active = true)
        {
            return db.Organisations.Where(x => x.RaceTracks.Any(t => t.ID == track.ID) && active ? (x.LicenseExpires == null || x.LicenseExpires >= DateTime.Today) : true);
        }
        public IQueryable<Organisation> GetByID(Guid id)
        {
            return db.Organisations.Where(x => x.ID == id);
        }
        #endregion
        public async Task Save(Organisation organisation, bool saveChanges = true)
        {
            if (organisation.ID != Guid.Empty && db.Organisations.Any(x => x.ID == organisation.ID))
                db.Update(organisation);
            else
            {
                if (organisation.ID == Guid.Empty)
                    organisation.ID = Guid.NewGuid();
                organisation.LicenseExpires = DateTime.Today.AddYears(1);
                await db.AddAsync(organisation);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
        public async Task Deactivate(Organisation organisation)
        {
            if (organisation.ID != Guid.Empty && db.Organisations.Any(x => x.ID == organisation.ID))
            {
                organisation.LicenseExpires = DateTime.Today;
                await db.SaveChangesAsync();
            }
        }
    }
}
