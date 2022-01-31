using Hylian.RIS.API.Domain.Enumerators;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class Race
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public Guid EventID { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public int OrderNr { get; set; }
        [Required]
        public Guid RaceTypeID { get; set; }
        [Required]
        public Guid DistanceID { get; set; }
        public Guid? BreedID { get; set; }
        public Guid? ClassID { get; set; }
        public Guid? SexID { get; set; }
        [Required]
        [DefaultValue(Announcement.LastToFirst)]
        public Announcement Announcement { get; set; }

        public virtual RaceEvent Event { get; set; }
        public virtual RaceType RaceType { get; set; }
        public virtual Distance Distance { get; set; }
        public virtual Breed? Breed { get; set; }
        public virtual RaceClass? Class { get; set; }
        public virtual Sex? Sex { get; set; }
        public virtual List<Run>? Runs { get; set; }
    }
}
