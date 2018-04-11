using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Giorno1.Models
{
    public class ViewCompany
    {
        public int CompanyId { get; set; }

        public string Nome { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int NumeroDipendenti { get; set; }
        public DateTime? DataCostituzione { get; set; }
        public string Indirizzo { get; set; }
    }
}