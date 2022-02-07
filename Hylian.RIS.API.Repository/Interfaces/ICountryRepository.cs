using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface ICountryRepository
    {
        IQueryable<Country> GetAll();
        IQueryable<Country> GetByCode(string code);
        IQueryable<Country> GetByID(Guid id);
        Task Save(Country country, bool saveChanges = true);
    }
}