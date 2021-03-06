﻿using Newtonsoft.Json;
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
        public Company()
        {
            Contatti = new HashSet<Contact>();
        }

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

        [JsonIgnore]
        public virtual ICollection<Contact> Contatti { get; set; }

        [JsonIgnore]
        public virtual ICollection<Automobile> AutoAziendali { get; set; }
    }
}
