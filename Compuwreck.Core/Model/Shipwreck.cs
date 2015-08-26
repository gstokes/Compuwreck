using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compuwreck.Core.Model {
    public class Shipwreck {
        public int Shipwreck_id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Dimensions { get; set; }
        public string Tonnage { get; set; }
        public string Armament { get; set; }
        public DateTime? DateLost { get; set; }
        public string DateExtn { get; set; }
        public string Locality { get; set; }
        public string PosExtn { get; set; }
        public string Cargo { get; set; }
        public string WindDir { get; set; }
        public string WindForce { get; set; }
        public string References { get; set; }
        public string Remarks { get; set; }
        public string U_Boat { get; set; }

        public int? Event_FK { get; set; }
        public int? County_FK { get; set; }
        public int? GPS { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
