using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Giorno1Oggetti
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }

        [NotMapped]  // questo campo, proprietà,... non riguarda EF
        public string NomeCompleto
        {
            get
            {
                return Nome ?? "" + " " + Cognome ?? "";
            }
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNascita { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
    }
}