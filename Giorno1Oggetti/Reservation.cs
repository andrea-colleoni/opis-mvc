using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giorno1Oggetti
{
    [Table("Reservation")]
    public class Reservation
    {
        [Key]
        [Column(Order = 0)]
        public int ContactId { get; set; }
        [Key]
        [Column(Order = 1)]
        public string TelaioAuto { get; set; }
        [Key]
        [Column(Order = 2)]
        public DateTime DataViaggio { get; set; }

        [ForeignKey("ContactId")]
        public Contact contatto { get; set; }

        [ForeignKey("TelaioAuto")]
        public Automobile auto { get; set; }
    }
}
