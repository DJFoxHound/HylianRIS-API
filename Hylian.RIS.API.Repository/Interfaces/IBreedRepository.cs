using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IBreedRepository
    {
        Task<IList<Breed>> GetAll();
        Task<IList<Breed>> GetByCompetition(RaceCompetition competition);
        Task<Breed> GetByID(Guid id);
        Task Save(Breed breed, bool saveChanges = true);
    }
}