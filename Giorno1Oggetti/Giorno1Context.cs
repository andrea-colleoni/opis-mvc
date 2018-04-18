using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Text;

namespace Giorno1Oggetti
{
    public partial class Giorno1Context : DbContext
    {
        public Giorno1Context() : base("name=giorno1") 
        {
            // per disabilitare migrations (gestisco a mano le modifice DB <=> Entities)
            Database.SetInitializer<Giorno1Context>(null);

            // per creare il DB se non esiste e usare migrations
            //Database.SetInitializer<Giorno1Context>(new CreateDatabaseIfNotExists<Giorno1Context>());
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Automobile> Cars { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
    }
}
