using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlTienda.Data.Entities
{
    public class Category:IEntity
    {
        public int Id { set; get; }
        [MaxLength(30)]
        public string Name { set; get; }
        [MaxLength(250)]
        public string Description { set; get; }
       
       
    }
}
