

namespace ControlTienda.Data
{
    using ControlTienda.Data.Entities;
    using System;
    public class DetailPurchaseRepository : GenericRepository<Details_Purchase>, IDetailPurchaseRepository
    {
        public DetailPurchaseRepository(DataContext context) : base(context)
        {

        }
    }
}
