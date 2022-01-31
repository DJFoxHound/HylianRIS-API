using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class Person
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? Location { get; set; }
        [Required]
        public Guid CountryID { get; set; }        
        public Guid? AccountID { get; set; }
        public DateTime? Deleted { get; set; }
        public DateTime? Anonymised { get; set; }

        public virtual Country Country { get; set; }
        public virtual Account? Account { get; set; }
        public virtual List<Dog>? Dogs { get; set; }
    }
}
