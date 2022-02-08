using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class RaceEvent: MultiLanguageName
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime RegistrationCloses { get; set; }
        [Required]
        public Guid OrganisationID { get; set; }
        [Required]
        public Guid TrackID { get; set; }
        [Required]
        public Guid CompetitionID { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool IsOfficial { get; set; }
        public DateTime? Deleted { get; set; }

        public virtual List<CrewMember>? Crew { get; set; }
        public virtual List<Dog>? Participants { get; set; }
        public virtual List<Race>? Races { get; set; }
        public virtual Organisation Organisation { get; set; }
        public virtual RaceTrack Track { get; set; }
        public virtual RaceCompetition Competition { get; set; }
        public virtual List<EventDelegate>? Delegates { get; set; }

    }
}
