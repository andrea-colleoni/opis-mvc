using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giorno1Oggetti
{
    [Table("SubItem1")]
    public class SubItem1 : Item // eg: text
    {
        public string subProp1 { get; set; }

    }
}
