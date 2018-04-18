using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giorno1Oggetti
{
    public abstract class Item
    {
        [Key]
        public int Chiave { get; set; }

        public string propItem { get; set; }

        [Required]
        public Child1 child1 { get; set; }

        public Child2 child2 { get; set; }
    }
}
