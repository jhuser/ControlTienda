using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Product
    {
        public int ID { set; get; }
        public string BarCode { set; get; }
        public string Name { set; get; }
        public decimal Price { set; get; }
        public int Stock { set; get; }
    }
}
