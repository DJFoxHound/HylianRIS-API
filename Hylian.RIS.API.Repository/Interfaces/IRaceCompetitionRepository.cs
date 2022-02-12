using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRaceCompetitionRepository
    {
        Task<IList<RaceCompetition>> GetAll(bool? isProffesional = null);
        Task<RaceCompetition> GetByID(Guid id);
        Task Save(RaceCompetition competition, bool saveChanges = true);
    }
}