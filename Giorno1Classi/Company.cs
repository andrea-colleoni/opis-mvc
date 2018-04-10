using System;
using System.Collections.Generic;
using System.Text;

namespace Giorno1Oggetti
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string Nome { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int NumeroDipendenti { get; set; }
        public DateTime DataCostituzione { get; set; }

        public ICollection<Contact> Contatti { get; set; }
    }
}
