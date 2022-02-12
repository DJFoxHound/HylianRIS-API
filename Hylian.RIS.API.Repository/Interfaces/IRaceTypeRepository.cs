using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceTypeRepository
    {
        Task<IList<RaceType>> GetAll(bool? isOfficial = null);
        Task<IList<RaceType>> GetByCompetition(RaceCompetition competition, bool? isOfficial = null);
        Task<RaceType> GetByID(Guid id);
        Task Save(RaceType type, bool saveChanges = true);
    }
}