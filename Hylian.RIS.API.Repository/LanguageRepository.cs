using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    public class LanguageRepository : ILanguageRepository
    {
        DbaseContext db;

        public LanguageRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public IQueryable<Language> GetAll(bool translatedOnly = false)
        {
            return db.Languages.Where(x => translatedOnly ? x.Translated == true : true);
        }
        public IQueryable<Language> GetByCode(string code)
        {
            return db.Languages.Where(x => x.Code == code.ToLowerInvariant());
        }
        #endregion
        public async Task Save(Language language, bool saveChanges = true)
        {
            if (!db.Languages.Any(x => x.ID != language.ID && x.Code == language.Code))
            {
                if (db.Languages.Any(x => x.ID == language.ID))
                    db.Update(language);
                else
                {
                    if (language.ID == Guid.Empty)
                        language.ID = Guid.NewGuid();
                    await db.AddAsync(language);
                }
                if (saveChanges)
                    await db.SaveChangesAsync();
            }
        }
    }
}
