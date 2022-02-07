using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class Account
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Phone { get; set; }
        public Guid? AddressID { get; set; }
        public DateTime? Deleted { get; set; }
        public DateTime? Anonymised { get; set; }

        public List<Person>? Persons { get; set; }
        public virtual List<AccountRole>? Roles { get; set; }
        public virtual List<EventDelegate>? DelegatingEvents { get; set; }
        public virtual Address? Address { get; set; }

    }
}
