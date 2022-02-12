using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRunResultTypeRepository
    {
        Task<IList<RunResultType>> GetAll();
        Task<RunResultType> GetByCode(string code);
        Task<RunResultType> GetByID(Guid id);
        Task Save(RunResultType runResultType, bool saveChanges = true);
    }
}