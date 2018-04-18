using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giorno1Oggetti
{
    public class EreditarietaContext : DbContext
    {
        public EreditarietaContext() : base("name=giorno4") 
        {
            // per disabilitare migrations (gestisco a mano le modifice DB <=> Entities)
            //Database.SetInitializer<Giorno1Context>(null);

            // per creare il DB se non esiste e usare migrations
            Database.SetInitializer<EreditarietaContext>(new CreateDatabaseIfNotExists<EreditarietaContext>());
        }

        public virtual DbSet<Child1> Child1 { get; set; }
        public virtual DbSet<Child2> Child2 { get; set; }
        public virtual DbSet<Item> Item { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<Child2>()
            //    .HasRequired(c => c.item)
            //    .WithOptional(i => i.child2)
            //    .Map(p => p.MapKey("ChiaveItem"));
        }
    }
}
