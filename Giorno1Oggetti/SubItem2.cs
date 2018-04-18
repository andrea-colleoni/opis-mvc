using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giorno1Oggetti
{
    [Table("SubItem2")]
    public class SubItem2 : Item // eg: radio
    {
        public string subProp2 { get; set; }
    }
}
