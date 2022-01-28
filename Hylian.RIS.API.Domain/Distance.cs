using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Domain
{
    public class Distance: MultiLanguageName
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public int Length { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool IsOfficial { get; set; }
        public virtual List<RaceTrack> Tracks { get; set; }
    }
}
