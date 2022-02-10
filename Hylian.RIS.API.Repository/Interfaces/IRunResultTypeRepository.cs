using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface IRunResultTypeRepository
    {
        IQueryable<RunResultType> GetAll();
        IQueryable<RunResultType> GetByCode(string code);
        IQueryable<RunResultType> GetByID(Guid id);
        Task Save(RunResultType runResultType, bool saveChanges = true);
    }
}