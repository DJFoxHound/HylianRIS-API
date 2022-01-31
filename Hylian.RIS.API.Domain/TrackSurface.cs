using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hylian.RIS.API.Domain
{
    public class TrackSurface : MultiLanguageName
    {
        [Key]
        public Guid ID { get; set; }
        public virtual List<RaceTrack>? Tracks { get; set; }
    }
}