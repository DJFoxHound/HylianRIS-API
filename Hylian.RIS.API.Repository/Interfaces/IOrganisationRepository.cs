using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IOrganisationRepository
    {
        Task Deactivate(Organisation organisation);
        Task<IList<Organisation>> GetAll(bool active = true);
        Task<IList<Organisation>> GetBy(RaceCompetition competition = null, Country country = null, bool active = true);
        Task<Organisation> GetByID(Guid id, bool active = true);
        Task<bool> IsValidID(Guid id);
        Task<IList<Organisation>> GetByTrack(RaceTrack track, bool active = true);
        Task Save(Organisation organisation, bool saveChanges = true);
    }
}