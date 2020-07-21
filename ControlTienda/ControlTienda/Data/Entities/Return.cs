using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Return
    {
        public int ID { set; get; }

        public int quantity { set; get; }
        public string observations { set; get; }
    }
}
