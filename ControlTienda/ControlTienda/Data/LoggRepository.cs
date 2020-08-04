
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data

{
    using ControlTienda.Data.Entities;
    using System;
     public class LoggRepository : GenericRepository<Product>, ISaleRepository
    {
        public LoggRepository(DataContext context): base(context) 
        {
        
        }
    }
}
