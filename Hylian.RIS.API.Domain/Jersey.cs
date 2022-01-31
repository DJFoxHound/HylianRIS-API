using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hylian.RIS.API.Domain
{
    public class Jersey: MultiLanguageName
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public string _Codes { get; set; }
        [Required]
        public Guid CompetitionID { get; set; }

        [NotMapped]
        public List<LanguageText> Codes
        {
            get { return _Codes == null ? null : JsonConvert.DeserializeObject<List<LanguageText>>(_Codes); }
            set { _Codes = JsonConvert.SerializeObject(value); }
        }

        public virtual RaceCompetition Competition { get; set; }
    }
}
