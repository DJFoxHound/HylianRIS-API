using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hylian.RIS.API.Domain
{
    public class Sex : MultiLanguagePluralName
    {
        [Key]
        public Guid ID { get; set; }
        [NotMapped]
        private string code;
        [Required]
        [StringLength(1, MinimumLength = 1)]
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