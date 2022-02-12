using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class CrewMemberRepository : ICrewMemberRepository
    {
        DbaseContext db;

        public CrewMemberRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<CrewMember>> GetAll()
        {
            return await db.CrewMembers.Include(c => c.CrewType).ToListAsync();
        }
        public async Task<IList<CrewMember>> GetByPerson(Person person, DateTime? from = null)
        {
            return await db.CrewMembers.Include(c => c.CrewType).Where(x => x.PersonID == person.ID && from.HasValue ? x.Event.Date >= from.Value : true).ToListAsync();
        }
        public async Task<IList<CrewMember>> GetByEvent(RaceEvent raceEvent)
        {
            return await db.CrewMembers.Include(c => c.CrewType).Where(x => x.EventID == raceEvent.ID).ToListAsync();
        }
        #endregion
        public async Task Save(CrewMember crewMember, bool saveChanges = true)
        {
            if (crewMember.EventID != Guid.Empty && crewMember.PersonID != Guid.Empty && crewMember.CrewTypeID != Guid.Empty)
            {
                if (db.CrewMembers.Include(c => c.CrewType).Any(x => x.EventID == crewMember.EventID && x.PersonID == crewMember.PersonID && x.CrewTypeID == crewMember.CrewTypeID))
                    db.Update(crewMember);
                else
                {
                    await db.AddAsync(crewMember);
                }
                if (saveChanges)
                    await db.SaveChangesAsync();
            }
        }
    }
}
