using Hylian.RIS.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface ISexRepository
    {
        Task<IList<Sex>> GetAll();
        Task<Sex> GetByCode(string code);
        Task<Sex> GetByID(Guid id);
        Task Save(Sex Sex, bool saveChanges = true);
    }
}