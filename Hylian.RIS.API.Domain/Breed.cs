using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class Breed: MultiLanguagePluralName
    {
        [Key]
        public Guid ID { get; set; }
        public string? ExternalSystemUrl { get; set; }

        public virtual List<RaceClass> Classes { get; set; }
        public virtual List<AgeRestriction> AgeRestrictions { get; set; }
    }
}