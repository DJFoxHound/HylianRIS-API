using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hylian.RIS.API.Domain
{
    public class RunResultType: MultiLanguageName
    {
        [Key]
        public Guid ID { get; set; }
        [NotMapped]
        private string code;
        [Required]
        [StringLength(3, MinimumLength = 2)]
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
        [Required]
        public int Order { get; set; }
    }
}
