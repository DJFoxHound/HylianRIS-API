using Hylian.RIS.API.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface ISexRepository
    {
        IQueryable<Sex> GetAll();
        IQueryable<Sex> GetByCode(string code);
        IQueryable<Sex> GetByID(Guid id);
        Task Save(Sex Sex, bool saveChanges = true);
    }
}