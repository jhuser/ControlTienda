using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class sale
    {
        public int ID { set; get; }
        public DateTime date_hour { set; get; }
        public int quantity { set; get; }
        public decimal amount { set; get; }
    }
}
