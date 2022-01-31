using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class Organisation
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Guid AddressID { get; set; }
        [Required]
        public Guid CompetitionID { get; set; }
        public string? Logo { get; set; }
        public DateTime? LicenseExpires { get; set; }

        public virtual RaceCompetition Competition { get; set; }
        public virtual List<Contact>? Contacts { get; set; }
        public virtual List<AccountRole>? Roles { get; set; }
        public virtual List<RaceTrack>? RaceTracks { get; set; }
        public virtual List<RaceEvent>? Events { get; set; }
        public virtual Address? Address { get; set; }
    }
}
