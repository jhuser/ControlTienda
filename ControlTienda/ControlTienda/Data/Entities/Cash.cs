using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Cash
    {
        public int ID { set; get; }
        public decimal unit_amount { set; get; }
        public decimal total_amount { set; get; }
        public DateTime Date { set; get; }
        public string observations { set; get; }
    }
}
