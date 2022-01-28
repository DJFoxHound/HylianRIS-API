using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class CrewType: MultiLanguageName
    {
        [Key]
        public Guid ID { get; set; }
    }
}
