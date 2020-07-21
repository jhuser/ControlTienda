using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Cash_Flow
    {
        public int ID { set; get;}
        public DateTime Date { set; get; }
        public decimal income_amount { set; get; }
        public decimal disbursement_amount { set; get; }

    }
}
