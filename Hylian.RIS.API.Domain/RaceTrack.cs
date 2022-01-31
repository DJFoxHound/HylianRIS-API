using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class RaceTrack
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string Code { get; set; }
        public string? Logo { get; set; }
        public string? Photo { get; set; }
        [Required]
        public virtual List<RaceCompetition> Competitions { get; set; }
        [Required]
        public virtual List<Distance> Distances { get; set; }
        public virtual List<Organisation>? Organisations { get; set; }
        public virtual List<RaceEvent>? Events { get; set; }
        public virtual List<TrackRecord>? TrackRecords { get; set; }
    }
}
