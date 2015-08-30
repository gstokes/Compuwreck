using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compuwreck.Core.Model {
    public class Photo {
        public int Photo_id { get; private set; }
        public string Name { get; private set; }
        public string Details { get; private set; }
        public string FileName { get; private set; }
        public string URL { get; private set; }
        public string Source { get; private set; }
        public int Shipwreck_id { get; private set; }

        public virtual Shipwreck Shipwreck { get; private set; }
    }
}
