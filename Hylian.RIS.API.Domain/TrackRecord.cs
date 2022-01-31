using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class TrackRecord
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public Guid DistanceID { get; set; }
        [Required]
        public Guid BreedID { get; set; }
        [Required]
        public Guid SexID { get; set; }
        [Required]
        public Guid TrackID { get; set; }
        public Guid? RunID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string DogName { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool IsPreSystem { get; set; }

        public virtual Distance Distance { get; set; }
        public virtual Breed Breed { get; set; }
        public virtual Sex Sex { get; set; }
        public virtual RaceTrack Track { get; set; }
        public virtual Run? Run { get; set; }

    }
}
