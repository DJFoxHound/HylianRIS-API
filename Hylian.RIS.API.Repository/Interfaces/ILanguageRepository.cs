using Hylian.RIS.API.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface ILanguageRepository
    {
        Task<IList<Language>> GetAll(bool translatedOnly = false);
        Task<Language> GetByCode(string code);
        Task Save(Language language, bool saveChanges = true);
    }
}