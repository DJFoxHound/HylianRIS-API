using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    internal class PersonRepository : IPersonRepository
    {
        DbaseContext db;

        public PersonRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<Person>> GetAll(bool active = true)
        {
            return await db.Persons.Where(x => active ? !x.FirstName.StartsWith("Anonymised") : true).ToListAsync();
        }
        public async Task<IList<Person>> GetByCountry(Country country = null, bool active = true)
        {
            return await db.Persons.Where(x => country != null ? x.CountryID == country.ID : true && active ? !x.FirstName.StartsWith("Anonymised") : true).ToListAsync();
        }
        public async Task<IList<Person>> GetByAccount(Account account, bool active = true)
        {
            return await db.Persons.Where(x => x.AccountID == account.ID && active ? !x.FirstName.StartsWith("Anonymised") : true).ToListAsync();
        }
        public async Task<IList<Person>> GetLikeAccount(Account account, bool active = true)
        {
            return await db.Persons.Where(x => !x.AccountID.HasValue && active ? !x.FirstName.StartsWith("Anonymised") : true && DbFunctions.IsSimilar(account.FirstName, x.FirstName) && DbFunctions.IsSimilar(account.LastName, x.LastName)).ToListAsync();
        }
        public async Task<Person> GetByDog(Dog dog, bool active = true)
        {
            return await db.Persons.FirstOrDefaultAsync(x => x.Dogs.Any(d => d.ID == dog.ID) && active ? !x.FirstName.StartsWith("Anonymised") : true);
        }
        public async Task<Person> GetByID(Guid id)
        {
            return await db.Persons.FirstOrDefaultAsync(x => x.ID == id);
        }
        #endregion
        public async Task Save(Person person, bool saveChanges = true)
        {
            if (person.ID != Guid.Empty && db.Persons.Any(x => x.ID == person.ID))
                db.Update(person);
            else
            {
                if (person.ID == Guid.Empty)
                    person.ID = Guid.NewGuid();
                await db.AddAsync(person);
            }
            if (saveChanges)
                await db.SaveChangesAsync();
        }
        public async Task Delete(Person person, bool saveChanges = true)
        {
            if (person.ID != Guid.Empty && db.Persons.Any(x => x.ID == person.ID))
            {
                person.Deleted = DateTime.UtcNow;
                await Save(person, saveChanges);
            }
        }
        public async Task Anonymise(Person person, bool saveChanges = true)
        {
            if (person.ID != Guid.Empty && db.Persons.Any(x => x.ID == person.ID && x.Deleted.HasValue && !x.Anonymised.HasValue))
            {
                person.Anonymised = DateTime.UtcNow;
                var anonymisedText = $"Anonymised{person.Anonymised.Value.Ticks}";
                person.FirstName = anonymisedText;
                person.LastName = anonymisedText;
                person.Location = anonymisedText;
                if (saveChanges)
                    await db.SaveChangesAsync();
            }
        }
    }
}
