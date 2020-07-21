using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class sale_detail
    {
        public int ID { set; get; }
        public DateTime Date_Hour { set; get; }
        public int quantity { set; get; }
        public decimal unit_amount { set; get; }
        public decimal total_amount { set; get; }
    }
}
