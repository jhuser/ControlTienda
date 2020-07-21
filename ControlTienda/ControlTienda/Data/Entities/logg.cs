using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class logg
    {
        public int ID { set; get; }
        public DateTime Date_Hour_entry { set; get; }
        public DateTime Date_Hour_exit { set; get; }
        public string observations { set; get; }
    }
}
