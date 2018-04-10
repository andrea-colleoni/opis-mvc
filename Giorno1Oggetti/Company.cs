using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Giorno1Oggetti
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [DisplayName("Ragione sociale")]
        [Required(ErrorMessage = "La ragione sociale è obbligatoria")]
        [StringLength(50)]
        public string Nome { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int NumeroDipendenti { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DataCostituzione { get; set; }
        [Column("Address")]
        public string Indirizzo { get; set; }

        public ICollection<Contact> Contatti { get; set; }
    }
}
