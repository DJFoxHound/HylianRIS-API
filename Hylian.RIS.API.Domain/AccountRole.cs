using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class AccountRole
    {
        [Required]
        public Guid AccountID { get; set; }
        [Required]
        public Guid RoleID { get; set; }
        [Required]
        public Guid OrganisationID { get; set; }

        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
        public virtual Organisation Organisation { get; set; }

    }
}
