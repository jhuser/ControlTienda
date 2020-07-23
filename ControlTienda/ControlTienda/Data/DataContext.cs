using ControlTienda.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlTienda.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Cash> Cashes { set; get; }
        public DbSet<Cash_Flow> cash_Flows { set; get; }
        public DbSet<category> categories { set; get; }
        public DbSet<Details_Purchase> Details_Purchases { set; get; }
        public DbSet<Sale> sales { set; get; }
        public DbSet<logg> loggs { set; get; }
        public DbSet<Product> products { set; get; }
        public DbSet<Purchase> purchases { set; get; }
        public DbSet<Refund> refunds { set; get; }
        public DbSet<Rol> rols { set; get; }
        public DbSet<sale_detail> sale_Details { set; get; }
        public DbSet<user> users { set; get; }


    }
}
