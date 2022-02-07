using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IPersonRepository
    {
        Task Anonymise(Person person, bool saveChanges = true);
        IQueryable<Person> GetAll(bool active = true);
        IQueryable<Person> GetByAccount(Account account, bool active = true);
        IQueryable<Person> GetByCountry(Country country = null, bool active = true);
        IQueryable<Person> GetByDog(Dog dog, bool active = true);
        IQueryable<Person> GetByID(Guid id);
        IQueryable<Person> GetLikeAccount(Account account, bool active = true);
        Task Save(Person person, bool saveChanges = true);
        Task Delete(Person person, bool saveChanges = true);
    }
}