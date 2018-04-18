namespace MigrazioneEntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EsempioMigrazioneCF : DbContext
    {
        public EsempioMigrazioneCF()
            : base("name=EsempioMigrazioneCF")
        {
        }

        public virtual DbSet<Azienda> Companies { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<vw_contatti_con_company> vw_contatti_con_company { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Azienda>()
                .Property(e => e.Address)
                .IsUnicode(false);
        }
    }
}
