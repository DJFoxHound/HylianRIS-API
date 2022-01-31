using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hylian.RIS.API.Domain
{
    public abstract class MultiLanguageName
    {
        [Required]
        [Column("Names")]
        public string _Names { get; set; }

        [NotMapped]
        public List<LanguageText> Names
        {
            get { return _Names == null ? null : JsonConvert.DeserializeObject<List<LanguageText>>(_Names); }
            set { _Names = JsonConvert.SerializeObject(value); }
        }
    }
}
