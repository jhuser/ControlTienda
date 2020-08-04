using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Product : IEntity
    {
        public int Id { set; get; }
        public DateTime? Date_Hour_entry { set; get; }
        public DateTime? Date_Hour_exit { set; get; }
        [MaxLength(250)]
        public string Remark { set; get; }
        public User user { set; get; }
    }
}
