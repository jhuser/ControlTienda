using ControlTienda.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data
{
   
     public class DetailSaleRepository : GenericRepository<Sale_detail>, IDetailSaleRepository
    {
        public DetailSaleRepository(DataContext context) : base(context)
        {

        }
    }
}

