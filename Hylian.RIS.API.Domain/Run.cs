using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class Run
    {
        [Key]
        public Guid ID { get; set; }
        public Guid? DogID { get; set; }
        [Required]
        public Guid JerseyID { get; set; }
        [Required]
        public Guid RaceID { get; set; }
        public Guid? ResultTypeID { get; set; }
        public long? TimeTicks { get; set; }
        public int? ResultOrder { get; set; }

        public virtual Dog? Dog { get; set; }
        public virtual Jersey Jersey { get; set; }
        public virtual Race Race { get; set; }
        public virtual RunResultType? ResultType { get; set; }
    }
}
