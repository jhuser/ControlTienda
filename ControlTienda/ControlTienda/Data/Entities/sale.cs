using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Sale:IEntity
    {
        public int Id { set; get; } 
        public DateTime? date_hour { set; get; }
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public int Quantity { set; get; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Amount { set; get; }
        public Cash_Flow cash_Flow { set; get; }
        public int CashFlowId { set; get; }
        public User user { set; get; }
        public int UserId { set; get; }
    }
}
