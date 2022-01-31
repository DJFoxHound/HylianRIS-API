using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hylian.RIS.API.Domain
{
    public class Language
    {
        [Key]
        public Guid ID { get; set; }
        [NotMapped]
        private string code;
        [Required]
        //[Index(IsUnique = true)]
        [StringLength(2, MinimumLength = 2)]
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value.ToLowerInvariant();
            }
        }
        [Required]
        public string Name { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool Translated { get; set; }
    }
}
