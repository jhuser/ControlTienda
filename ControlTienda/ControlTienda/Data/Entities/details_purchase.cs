using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace ControlTienda.Data.Entities
{
    public class Details_Purchase
    {
        public int ID { set; get; }
        public DateTime?  date_hour { set; get;}
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public int quantity { set; get; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Unit_Price { set; get; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal total_amount { set; get; }

    }
}
