using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class RaceLicense
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public Guid DogID { get; set; }
        [Required]
        public Guid RaceClassId { get; set; }
        [Required]
        public Guid CompetitionID { get; set; }
        [Required]
        public string LicenseNumber { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        public virtual Dog Dog { get; set; }
        public virtual RaceClass RaceClass { get; set; }
        public virtual RaceCompetition Competition { get; set; }
    }
}
