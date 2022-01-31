using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class AgeRestriction
    {
        [Required]
        public Guid BreedID { get; set; }
        [Required]
        public Guid CompetitionID { get; set; }
        [Required]
        public int MinAge { get; set; }
        [Required]
        public int MaxAge { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool TillEndOfYear { get; set; }
        public virtual Breed Breed { get; set; }
        public virtual RaceCompetition Competition { get; set; }
    }
}
