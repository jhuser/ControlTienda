using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Rol
    {
        public int ID { set; get; }
        [MaxLength(25)]
        public string Name { set; get; }
        [MaxLength(250)]
        public string Details { set; get;}
        public Rol rol { set; get; }
    }
}
