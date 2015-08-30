using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Compuwreck.Core.Model {
    public class CompuwreckContext : DbContext{
        static CompuwreckContext() {
            Database.SetInitializer<CompuwreckContext>(null);
        }
    }
}
