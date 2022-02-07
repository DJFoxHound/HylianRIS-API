using Hylian.RIS.API.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IAgeRestrictionRepository
    {
        IQueryable<AgeRestriction> GetAll();
        IQueryable<AgeRestriction> GetByBreed(Breed breed);
        IQueryable<AgeRestriction> GetByCompetition(RaceCompetition competition);
        Task Save(AgeRestriction ageRestriction, bool saveChanges = true);
    }
}