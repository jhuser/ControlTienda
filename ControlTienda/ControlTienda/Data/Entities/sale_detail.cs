using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Sale_detail : IEntity
    {
        public int Id { set; get; }
        public DateTime? Date_Hour { set; get; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public int quantity { set; get; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal unit_amount { set; get; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal total_amount { set; get; }

        public Product Product { set; get; }
        public int ProductId { set; get; }
        public Sale Sale { set; get; }
        public int SaleId {set;get;}
    }
}
