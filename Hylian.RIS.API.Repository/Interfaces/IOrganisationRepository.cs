using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IOrganisationRepository
    {
        Task Deactivate(Organisation organisation);
        IQueryable<Organisation> GetAll(bool active = true);
        IQueryable<Organisation> GetBy(RaceCompetition competition = null, Country country = null, bool active = true);
        IQueryable<Organisation> GetByID(Guid id);
        IQueryable<Organisation> GetByTrack(RaceTrack track, bool active = true);
        Task Save(Organisation organisation, bool saveChanges = true);
    }
}