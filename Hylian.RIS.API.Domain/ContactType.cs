using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
