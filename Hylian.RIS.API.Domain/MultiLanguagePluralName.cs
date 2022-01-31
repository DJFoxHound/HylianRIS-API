using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hylian.RIS.API.Domain
{
    public abstract class MultiLanguagePluralName: MultiLanguageName
    {
        [Required]
        [Column("PluralNames")]
        public string _PluralNames { get; set; }

        [NotMapped]
        public List<LanguageText> PluralNames
        {
            get { return _PluralNames == null ? null : JsonConvert.DeserializeObject<List<LanguageText>>(_PluralNames); }
            set { _PluralNames = JsonConvert.SerializeObject(value); }
        }
    }
}
