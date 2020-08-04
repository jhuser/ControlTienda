using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
     public class User: IEntity
    {
        public int Id { set; get; }
        [MaxLength(50)]
        public string Name { set; get; }
       [MaxLength(100)]
        public string Address { set; get; }
        [MaxLength(25)]
        public string Phone { set; get; }
        [MinLength(6, ErrorMessage = "At less you need 6 characters."),MaxLength(8, ErrorMessage = "At less you need 8 characters.")]
        public string Nickname { set; get; }
        [MinLength(8),MaxLength(15)]
        public string Password { set; get; }
        public Rol rol { set; get; }
    }
}
