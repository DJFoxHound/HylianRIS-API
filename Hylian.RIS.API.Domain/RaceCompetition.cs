using Hylian.RIS.API.Domain.Enumerators;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class RaceCompetition
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public List<RunnerType> RunnerTypes { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsProfessional { get; set; }
        public virtual List<Jersey>? Jerseys { get; set; }
        public virtual List<RaceTrack>? Tracks { get; set; }
        public virtual List<AgeRestriction>? AgeRestrictions { get; set; }
        public virtual List<RaceLicense>? Licenses { get; set; }
        public virtual List<RaceEvent>? Events { get; set; }
        public virtual List<RaceType>? RaceTypes { get; set; }
    }
}
