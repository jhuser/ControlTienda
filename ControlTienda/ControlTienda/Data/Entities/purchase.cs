using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
     public class purchase
    {
       public int ID { set; get; }
       public  DateTime Date_Hour { set; get; }
       public string Description { set; get; }
        public decimal amount { set; get; }
        public int quantity { set; get; }

    }
}
