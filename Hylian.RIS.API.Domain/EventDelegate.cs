using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class EventDelegate
    {
        public Guid EventID { get; set; }
        public Guid CountryID { get; set; }
        public Guid AccountID { get; set; }

        public virtual Account Delegate { get; set; }
        public virtual RaceEvent Event { get; set; }
        public virtual Country Country { get; set; }

    }
}
