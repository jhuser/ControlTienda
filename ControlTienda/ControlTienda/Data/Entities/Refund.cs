using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Refund
    {
        public int ID { set; get; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]

        public int Amount { set; get; }
        [MaxLength(250)]
        public string observations { set; get; }
    }
}
