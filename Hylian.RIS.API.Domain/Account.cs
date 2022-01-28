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
        public string Phone { get; set; }
        [Required]
        public Address Address { get; set; }

        public List<Person> Persons { get; set; }
        public virtual List<AccountRole> Roles { get; set; }

    }
}
