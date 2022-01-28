using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Domain
{
    public class AgeRestriction
    {
        [Required]
        public Guid BreedId { get; set; }
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
