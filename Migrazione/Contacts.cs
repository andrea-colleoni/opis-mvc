namespace Migrazione
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contacts
    {
        [Key]
        public int ContactId { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public DateTime DataNascita { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public int? CompanyId { get; set; }

        public virtual Companies Companies { get; set; }
    }
}
