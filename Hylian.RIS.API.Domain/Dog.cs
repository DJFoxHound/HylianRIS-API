using Hylian.RIS.API.Domain.Enumerators;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class Dog
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Guid BreedID { get; set; }
        [Required]
        public Guid SexID { get; set; }
        public DateTime? BirthDate { get; set; }
        [MaxLength(450)]
        public string? Pedigree { get; set; }
        [MaxLength(450)]
        public string? Chip { get; set; }
        [Required]
        public Guid OwnerID { get; set; }
        [Required]
        public Guid CountryID { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool Active { get; set; }
        [Required]
        [DefaultValue(RunnerType.Normal)]
        public RunnerType RunnerType { get; set; }

        public virtual Country Country { get; set; }
        public virtual Breed Breed { get; set; }
        public virtual Sex Sex { get; set; }
        public virtual Person Owner { get; set; }
        public virtual List<RaceLicense>? Licenses { get; set; }
        public virtual List<RaceEvent>? Events { get; set; }
        public virtual List<Run>? Runs { get; set; }
    }
}
