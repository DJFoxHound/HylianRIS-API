using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IBreedRepository
    {
        IQueryable<Breed> GetAll();
        IQueryable<Breed> GetByCompetition(RaceCompetition competition);
        IQueryable<Breed> GetByID(Guid id);
        Task Save(Breed breed, bool saveChanges = true);
    }
}