using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Product:IEntity
    {
        public int Id { set; get; }
        [MaxLength(25)]
        public string BarCode { set; get; }
        [MaxLength(150)]
        public string Name { set; get; }
        [DisplayFormat(DataFormatString ="{0:C2}",ApplyFormatInEditMode =false)]
        public decimal Price { set; get; }
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { set; get; }
       

        public Category Category { set; get; }
    }
}
