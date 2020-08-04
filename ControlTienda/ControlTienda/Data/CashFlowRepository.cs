

namespace ControlTienda.Data
{
    using ControlTienda.Data.Entities;
    using System;
    public class CashFlowRepository : GenericRepository<Cash_Flow>, ICashFlowRepository
    {
        public CashFlowRepository(DataContext context) : base(context)
        {

        }
    }
}
