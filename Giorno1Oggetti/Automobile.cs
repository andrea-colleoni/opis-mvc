using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giorno1Oggetti
{
    [Table("Car")]
    public class Automobile : MezzoTrasporto
    {
        [Key]
        public string Telaio { get; set; }

        [Required]
        public string Targa { get; set; }

        public int? CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public Company azienda { get; set; }

        // virtual => lazy load
        public virtual ICollection<Reservation> viaggi { get; set; }

    }
}
