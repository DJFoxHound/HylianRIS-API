using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface ICountryRepository
    {
        Task<IList<Country>> GetAll();
        Task<Country> GetByCode(string code);
        Task<Country> GetByID(Guid id);
        Task Save(Country country, bool saveChanges = true);
    }
}