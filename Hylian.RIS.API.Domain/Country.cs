using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hylian.RIS.API.Domain
{
    public class Country: MultiLanguageName
    {
        [Key]
        public Guid ID { get; set; }
        [NotMapped]
        private string code;
        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value.ToUpperInvariant();
            }
        }
    }
}
