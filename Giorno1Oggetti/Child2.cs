using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giorno1Oggetti
{
    public class Child2
    {
        public string child2Prop { get; set; }

        [Key]
        public int ChiaveItem { get; set; }

        [ForeignKey("ChiaveItem")]
        [Required]
        public Item item { get; set; }
    }
}
