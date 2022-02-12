using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class AddressRepository : IAddressRepository
    {
        DbaseContext db;

        public AddressRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<Address>> GetAll()
        {
            return await db.Addresses.Include(x => x.Country).ToListAsync();
        }
        public async Task<Address> GetByID(Guid id)
        {
            return await db.Addresses.Include(x => x.Country).FirstOrDefaultAsync(a => a.ID == id);
        }
        public async Task<IList<Address>> GetByCountry(Country country)
        {
            return await db.Addresses.Include(x => x.Country).Where(a => a.CountryID == country.ID).ToListAsync();
        }
        #endregion
        public async Task Save(Address address, bool saveChanges = true)
        {
            address.Coordinates = await GetGeocoding(address);
            if (address.ID != Guid.Empty && db.Addresses.Any(x => x.ID == address.ID))
                db.Update(address);
            else
            {
                if (address.ID == Guid.Empty)
                    address.ID = Guid.NewGuid();

                await db.AddAsync(address);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }

        public async Task<Point> GetGeocoding(Address address)
        {
            //TODO Call geocoding API
            return null;
        }

    }
}
