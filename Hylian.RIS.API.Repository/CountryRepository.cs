using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        public async Task<IList<Country>> GetAll()
        {
            return await db.Countries.ToListAsync();
        }
        public async Task<Country> GetByID(Guid id)
        {
            return await db.Countries.FirstOrDefaultAsync(x => x.ID == id);
        }
        public async Task<Country> GetByCode(string code)
        {
            return await db.Countries.FirstOrDefaultAsync(x => x.Code == code);
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
