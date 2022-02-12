using Hylian.RIS.API.Domain;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IAddressRepository
    {
        Task<IList<Address>> GetAll();
        Task<IList<Address>> GetByCountry(Country country);
        Task<Address> GetByID(Guid id);
        Task<Point> GetGeocoding(Address address);
        Task Save(Address address, bool saveChanges = true);
    }
}