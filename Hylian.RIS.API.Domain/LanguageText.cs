using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class LanguageText
    {
        [Required]
        public string LanguageCode { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
