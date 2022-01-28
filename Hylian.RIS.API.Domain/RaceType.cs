using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class RaceType: MultiLanguageName
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool IsOfficial { get; set; }
        public virtual List<RaceCompetition> Competitions { get; set; }
    }
}
