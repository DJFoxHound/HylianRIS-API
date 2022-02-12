using Hylian.RIS.API.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IAgeRestrictionRepository
    {
        Task<IList<AgeRestriction>> GetAll();
        Task<IList<AgeRestriction>> GetByBreed(Breed breed);
        Task<IList<AgeRestriction>> GetByCompetition(RaceCompetition competition);
        Task Save(AgeRestriction ageRestriction, bool saveChanges = true);
    }
}