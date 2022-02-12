using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceTrackRepository
    {
        Task<IList<RaceTrack>> GetAll(TrackSurface surface = null);
        Task<IList<RaceTrack>> GetByCompetition(RaceCompetition competition, TrackSurface surface = null);
        Task<IList<RaceTrack>> GetByCountry(Country country, TrackSurface surface = null);
        Task<RaceTrack> GetByID(Guid id);
        Task<IList<RaceTrack>> GetByOrganisation(Organisation organisation, TrackSurface surface = null);
        Task Save(RaceTrack track, bool saveChanges = true);
    }
}