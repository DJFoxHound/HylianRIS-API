using Hylian.RIS.API.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository.Interfaces
{
    public interface ILanguageRepository
    {
        IQueryable<Language> GetAll(bool translatedOnly = false);
        IQueryable<Language> GetByCode(string code);
        Task Save(Language language, bool saveChanges = true);
    }
}