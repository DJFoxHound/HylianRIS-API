using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class Role
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual List<AccountRole>? Accounts { get; set; }
    }
}
