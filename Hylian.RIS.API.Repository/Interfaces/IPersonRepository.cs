using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IPersonRepository
    {
        Task Anonymise(Person person, bool saveChanges = true);
        Task<IList<Person>> GetAll(bool active = true);
        Task<IList<Person>> GetByAccount(Account account, bool active = true);
        Task<IList<Person>> GetByCountry(Country country = null, bool active = true);
        Task<Person> GetByDog(Dog dog, bool active = true);
        Task<Person> GetByID(Guid id);
        Task<IList<Person>> GetLikeAccount(Account account, bool active = true);
        Task Save(Person person, bool saveChanges = true);
        Task Delete(Person person, bool saveChanges = true);
    }
}