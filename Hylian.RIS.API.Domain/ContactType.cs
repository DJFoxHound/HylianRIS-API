using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class ContactType
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Icon { get; set; }
    }
}
