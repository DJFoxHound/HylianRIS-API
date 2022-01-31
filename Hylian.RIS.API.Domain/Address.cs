using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;

namespace Hylian.RIS.API.Domain
{
    public class Address
    {
        [Key]
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? Street { get; set; }
        public string? StreetNumber { get; set; }
        public string? Box { get; set; }
        public string? PostCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public Guid? CountryID { get; set; }
        public Point? Coordinates { get; set; }
        public virtual Country? Country { get; set; }
    }
}
