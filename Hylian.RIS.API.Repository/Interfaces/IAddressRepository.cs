using Hylian.RIS.API.Domain;
using NetTopologySuite.Geometries;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IAddressRepository
    {
        IQueryable<Address> GetAll();
        IQueryable<Address> GetByCountry(Country country);
        IQueryable<Address> GetByID(Guid id);
        Task<Point> GetGeocoding(Address address);
        Task Save(Address address, bool saveChanges = true);
    }
}