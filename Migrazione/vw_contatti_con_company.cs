namespace Migrazione
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_contatti_con_company
    {
        //[Key]
        [StringLength(50)]
        public string Nome { get; set; }

        public string NomeContatto { get; set; }

        public string cognomecontatto { get; set; }
    }
}
