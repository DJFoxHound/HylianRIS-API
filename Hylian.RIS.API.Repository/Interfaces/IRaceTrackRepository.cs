using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceTrackRepository
    {
        IQueryable<RaceTrack> GetAll(TrackSurface surface = null);
        IQueryable<RaceTrack> GetByCompetition(RaceCompetition competition, TrackSurface surface = null);
        IQueryable<RaceTrack> GetByCountry(Country country, TrackSurface surface = null);
        IQueryable<RaceTrack> GetByID(Guid id);
        IQueryable<RaceTrack> GetByOrganisation(Organisation organisation, TrackSurface surface = null);
        Task Save(RaceTrack track, bool saveChanges = true);
    }
}