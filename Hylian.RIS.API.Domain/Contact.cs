using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class Contact
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public Guid OrganisationID { get; set; }
        [Required]
        public Guid TypeID { get; set; }

        public virtual ContactType Type { get; set; }
        public virtual Organisation Organisation { get; set; }
    }
}
