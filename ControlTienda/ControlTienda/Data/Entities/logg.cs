using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Logg
    {
        public int ID { set; get; }
        public DateTime? Date_Hour_entry { set; get; }
        public DateTime? Date_Hour_exit { set; get; }
        [MaxLength(250)]
        public string Remark { set; get; }
    }
}
