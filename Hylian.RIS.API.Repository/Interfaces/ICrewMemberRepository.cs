using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface ICrewMemberRepository
    {
        Task<IList<CrewMember>> GetAll();
        Task<IList<CrewMember>> GetByEvent(RaceEvent raceEvent);
        Task<IList<CrewMember>> GetByPerson(Person person, DateTime? from = null);
        Task Save(CrewMember crewMember, bool saveChanges = true);
    }
}