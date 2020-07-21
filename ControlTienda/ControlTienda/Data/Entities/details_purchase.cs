using System;
using System.Dynamic;

namespace ControlTienda.Data.Entities
{
    public class details_purchase
    {
        public int ID { set; get; }
        public DateTime date_hour { set; get;}
        public int quantity { set; get; }
        public decimal unit_amount { set; get; }
        public decimal total_amount { set; get; }

    }
}
