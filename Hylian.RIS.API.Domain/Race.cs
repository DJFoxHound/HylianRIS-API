using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class Race
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public Guid EventId { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public int OrderNr { get; set; }
        [Required]
        public Guid RaceTypeId { get; set; }
        [Required]
        public Guid DistanceId { get; set; }
        public Guid BreedId { get; set; }
        public Guid ClassId { get; set; }
        public Guid SexId { get; set; }

        public virtual RaceEvent Event { get; set; }
        public virtual RaceType RaceType { get; set; }
        public virtual Distance Distance { get; set; }
        public virtual Breed Breed { get; set; }
        public virtual RaceClass Class { get; set; }
        public virtual Sex Sex { get; set; }
        public virtual List<Run> Runs { get; set; }
    }
}
