using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Repository
{
    internal class LanguageRepository : ILanguageRepository
    {
        DbaseContext db;

        public LanguageRepository(DbaseContext dbContext)
        {
            db = dbContext;
        }
        #region Get
        public async Task<IList<Language>> GetAll(bool translatedOnly = false)
        {
            return await db.Languages.Where(x => translatedOnly ? x.Translated == true : true).ToListAsync();
        }
        public async Task<Language> GetByCode(string code)
        {
            return await db.Languages.FirstOrDefaultAsync(x => x.Code == code.ToLowerInvariant());
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
