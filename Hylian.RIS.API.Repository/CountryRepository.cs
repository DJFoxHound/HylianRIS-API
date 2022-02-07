using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class CountryRepository : ICountryRepository
    {
        DbaseContext db;

        public CountryRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<Country> GetAll()
        {
            return db.Countries;
        }
        public IQueryable<Country> GetByID(Guid id)
        {
            return db.Countries.Where(x => x.ID == id);
        }
        public IQueryable<Country> GetByCode(string code)
        {
            return db.Countries.Where(x => x.Code == code);
        }
        #endregion
        public async Task Save(Country country, bool saveChanges = true)
        {
            if (country.ID != Guid.Empty && db.Countries.Any(x => x.ID == country.ID))
                db.Update(country);
            else
            {
                if (country.ID == Guid.Empty)
                    country.ID = Guid.NewGuid();
                await db.AddAsync(country);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
    }
}
