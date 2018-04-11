using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Giorno1.Models
{
    public class ViewContact
    {
        public int ContactId { get; set; }
        public string name { get; set; }
        public string Cognome { get; set; }

        public string NomeCompleto
        {
            get
            {
                return name ?? "" + " " + Cognome ?? "";
            }
        }

        public DateTime DataNascita { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public int CompanyId { get; set; }

        public virtual ViewCompany Company { get; set; }
    }
}