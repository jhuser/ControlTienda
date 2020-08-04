using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
     public class Purchase:IEntity
    {
       public int Id { set; get; }
       public  DateTime? Date_Hour { set; get; }
        [MaxLength(250)]
       public string Remark { set; get; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { set; get; }
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public int quantity { set; get; }
       
        public Cash_Flow cash_Flow { set; get; }

    }
}
