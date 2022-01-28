using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hylian.RIS.API.Domain
{
    public class Address
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string Box { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Country Country { get; set; }
        public Point Coordinates { get; set; }
    }
}
