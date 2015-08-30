using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compuwreck.Core.Model {
    public class Location {
        public int LocationId { get; private set; }
        public int ShipwreckId { get; private set; }
        public double? LTD { get; private set; }
        public double? LNG { get; set; }
        public string Lat { get; private set; }
        public string Long { get; private set; }
        public System.Data.Entity.Spatial.DbGeography GeoLocation { get; private set; }

        public virtual Shipwreck Shipwreck { get; set; }
    }
}
