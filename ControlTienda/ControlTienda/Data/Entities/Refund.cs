using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Refund:IEntity
    {
        public int Id { set; get; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]

        public int Amount { set; get; }
        [MaxLength(250)]
        public string observations { set; get; }

        public Sale_detail Sale_Detail { set; get; }
        public int SaleDetailId { set; get; }
    }
}
