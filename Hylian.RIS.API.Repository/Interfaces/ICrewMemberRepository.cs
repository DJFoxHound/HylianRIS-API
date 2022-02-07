using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface ICrewMemberRepository
    {
        IQueryable<CrewMember> GetAll();
        IQueryable<CrewMember> GetByEvent(RaceEvent raceEvent);
        IQueryable<CrewMember> GetByPerson(Person person, DateTime? from = null);
        Task Save(CrewMember crewMember, bool saveChanges = true);
    }
}