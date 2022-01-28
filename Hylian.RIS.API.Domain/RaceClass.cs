using Hylian.RIS.API.Domain.Enumerators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hylian.RIS.API.Domain
{
    public class RaceClass: MultiLanguageName
    {
        [Key]
        public Guid ID { get; set; }
        [NotMapped]
        private string code;
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value.ToUpperInvariant();
            }
        }
        public int RequiredAge { get; set; }
        public ClassType ClassType { get; set; }
        public RaceCompetition Competition { get; set; }

        public Guid? MixedClassID { get; set; }
        public virtual RaceClass MixedClass { get; set; }
        public virtual List<Breed> Breeds { get; set; }
        public virtual List<RaceLicense> Licenses { get; set; }
    }
}
