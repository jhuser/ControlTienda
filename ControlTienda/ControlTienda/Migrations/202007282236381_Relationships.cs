namespace ControlTienda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relationships : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cashes", "cash_ID", c => c.Int());
            AddColumn("dbo.Details_Purchase", "Product_ID", c => c.Int());
            AddColumn("dbo.Details_Purchase", "Purchase_ID", c => c.Int());
            AddColumn("dbo.Loggs", "user_ID", c => c.Int());
            AddColumn("dbo.Products", "Category_ID", c => c.Int());
            AddColumn("dbo.Purchases", "cash_Flow_ID", c => c.Int());
            AddColumn("dbo.Refunds", "Sale_Detail_ID", c => c.Int());
            AddColumn("dbo.Rols", "rol_ID", c => c.Int());
            AddColumn("dbo.Sale_detail", "Product_ID", c => c.Int());
            AddColumn("dbo.Sale_detail", "Sale_ID", c => c.Int());
            AddColumn("dbo.Sales", "cash_Flow_ID", c => c.Int());
            AddColumn("dbo.Sales", "user_ID", c => c.Int());
            CreateIndex("dbo.Cashes", "cash_ID");
            CreateIndex("dbo.Details_Purchase", "Product_ID");
            CreateIndex("dbo.Details_Purchase", "Purchase_ID");
            CreateIndex("dbo.Products", "Category_ID");
            CreateIndex("dbo.Purchases", "cash_Flow_ID");
            CreateIndex("dbo.Loggs", "user_ID");
            CreateIndex("dbo.Refunds", "Sale_Detail_ID");
            CreateIndex("dbo.Sale_detail", "Product_ID");
            CreateIndex("dbo.Sale_detail", "Sale_ID");
            CreateIndex("dbo.Sales", "cash_Flow_ID");
            CreateIndex("dbo.Sales", "user_ID");
            CreateIndex("dbo.Rols", "rol_ID");
            AddForeignKey("dbo.Cashes", "cash_ID", "dbo.Cashes", "ID");
            AddForeignKey("dbo.Products", "Category_ID", "dbo.Categories", "ID");
            AddForeignKey("dbo.Details_Purchase", "Product_ID", "dbo.Products", "ID");
            AddForeignKey("dbo.Purchases", "cash_Flow_ID", "dbo.Cash_Flow", "ID");
            AddForeignKey("dbo.Details_Purchase", "Purchase_ID", "dbo.Purchases", "ID");
            AddForeignKey("dbo.Loggs", "user_ID", "dbo.Users", "ID");
            AddForeignKey("dbo.Sale_detail", "Product_ID", "dbo.Products", "ID");
            AddForeignKey("dbo.Sales", "cash_Flow_ID", "dbo.Cash_Flow", "ID");
            AddForeignKey("dbo.Sales", "user_ID", "dbo.Users", "ID");
            AddForeignKey("dbo.Sale_detail", "Sale_ID", "dbo.Sales", "ID");
            AddForeignKey("dbo.Refunds", "Sale_Detail_ID", "dbo.Sale_detail", "ID");
            AddForeignKey("dbo.Rols", "rol_ID", "dbo.Rols", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rols", "rol_ID", "dbo.Rols");
            DropForeignKey("dbo.Refunds", "Sale_Detail_ID", "dbo.Sale_detail");
            DropForeignKey("dbo.Sale_detail", "Sale_ID", "dbo.Sales");
            DropForeignKey("dbo.Sales", "user_ID", "dbo.Users");
            DropForeignKey("dbo.Sales", "cash_Flow_ID", "dbo.Cash_Flow");
            DropForeignKey("dbo.Sale_detail", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.Loggs", "user_ID", "dbo.Users");
            DropForeignKey("dbo.Details_Purchase", "Purchase_ID", "dbo.Purchases");
            DropForeignKey("dbo.Purchases", "cash_Flow_ID", "dbo.Cash_Flow");
            DropForeignKey("dbo.Details_Purchase", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.Products", "Category_ID", "dbo.Categories");
            DropForeignKey("dbo.Cashes", "cash_ID", "dbo.Cashes");
            DropIndex("dbo.Rols", new[] { "rol_ID" });
            DropIndex("dbo.Sales", new[] { "user_ID" });
            DropIndex("dbo.Sales", new[] { "cash_Flow_ID" });
            DropIndex("dbo.Sale_detail", new[] { "Sale_ID" });
            DropIndex("dbo.Sale_detail", new[] { "Product_ID" });
            DropIndex("dbo.Refunds", new[] { "Sale_Detail_ID" });
            DropIndex("dbo.Loggs", new[] { "user_ID" });
            DropIndex("dbo.Purchases", new[] { "cash_Flow_ID" });
            DropIndex("dbo.Products", new[] { "Category_ID" });
            DropIndex("dbo.Details_Purchase", new[] { "Purchase_ID" });
            DropIndex("dbo.Details_Purchase", new[] { "Product_ID" });
            DropIndex("dbo.Cashes", new[] { "cash_ID" });
            DropColumn("dbo.Sales", "user_ID");
            DropColumn("dbo.Sales", "cash_Flow_ID");
            DropColumn("dbo.Sale_detail", "Sale_ID");
            DropColumn("dbo.Sale_detail", "Product_ID");
            DropColumn("dbo.Rols", "rol_ID");
            DropColumn("dbo.Refunds", "Sale_Detail_ID");
            DropColumn("dbo.Purchases", "cash_Flow_ID");
            DropColumn("dbo.Products", "Category_ID");
            DropColumn("dbo.Loggs", "user_ID");
            DropColumn("dbo.Details_Purchase", "Purchase_ID");
            DropColumn("dbo.Details_Purchase", "Product_ID");
            DropColumn("dbo.Cashes", "cash_ID");
        }
    }
}
