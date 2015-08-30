using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compuwreck.Core.Model {
   public class Reference {
       public int ID { get; private set; }
       public string AbreviatedTitle { get; private set; }
       public string LongTitle { get; private set; }
       public string Author { get; private set; }
       public string PublisherSource { get; private set; }
       public string PublishersAddress { get; private set; }
       public string Source { get; private set; }
       public string DatePublished { get; private set; }
       public string RelevantMaterial { get; private set; }
       public string ISBN { get; private set; }
    }
}
