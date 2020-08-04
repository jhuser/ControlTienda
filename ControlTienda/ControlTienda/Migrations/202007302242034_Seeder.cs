namespace ControlTienda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seeder : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Cashes", new[] { "cash_ID" });
            DropIndex("dbo.Details_Purchase", new[] { "Product_ID" });
            DropIndex("dbo.Details_Purchase", new[] { "Purchase_ID" });
            DropIndex("dbo.Products", new[] { "Category_ID" });
            DropIndex("dbo.Purchases", new[] { "cash_Flow_ID" });
            DropIndex("dbo.Loggs", new[] { "user_ID" });
            DropIndex("dbo.Refunds", new[] { "Sale_Detail_ID" });
            DropIndex("dbo.Sale_detail", new[] { "Product_ID" });
            DropIndex("dbo.Sale_detail", new[] { "Sale_ID" });
            DropIndex("dbo.Sales", new[] { "cash_Flow_ID" });
            DropIndex("dbo.Sales", new[] { "user_ID" });
            DropIndex("dbo.Rols", new[] { "rol_ID" });
            AddColumn("dbo.Categories", "Description", c => c.String(maxLength: 250));
            AddColumn("dbo.Users", "rol_Id", c => c.Int());
            CreateIndex("dbo.Cashes", "cash_Id");
            CreateIndex("dbo.Details_Purchase", "Product_Id");
            CreateIndex("dbo.Details_Purchase", "Purchase_Id");
            CreateIndex("dbo.Products", "Category_Id");
            CreateIndex("dbo.Purchases", "cash_Flow_Id");
            CreateIndex("dbo.Loggs", "user_Id");
            CreateIndex("dbo.Users", "rol_Id");
            CreateIndex("dbo.Rols", "rol_Id");
            CreateIndex("dbo.Refunds", "Sale_Detail_Id");
            CreateIndex("dbo.Sale_detail", "Product_Id");
            CreateIndex("dbo.Sale_detail", "Sale_Id");
            CreateIndex("dbo.Sales", "cash_Flow_Id");
            CreateIndex("dbo.Sales", "user_Id");
            AddForeignKey("dbo.Users", "rol_Id", "dbo.Rols", "Id");
            DropColumn("dbo.Categories", "Remark");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Remark", c => c.String(maxLength: 250));
            DropForeignKey("dbo.Users", "rol_Id", "dbo.Rols");
            DropIndex("dbo.Sales", new[] { "user_Id" });
            DropIndex("dbo.Sales", new[] { "cash_Flow_Id" });
            DropIndex("dbo.Sale_detail", new[] { "Sale_Id" });
            DropIndex("dbo.Sale_detail", new[] { "Product_Id" });
            DropIndex("dbo.Refunds", new[] { "Sale_Detail_Id" });
            DropIndex("dbo.Rols", new[] { "rol_Id" });
            DropIndex("dbo.Users", new[] { "rol_Id" });
            DropIndex("dbo.Loggs", new[] { "user_Id" });
            DropIndex("dbo.Purchases", new[] { "cash_Flow_Id" });
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropIndex("dbo.Details_Purchase", new[] { "Purchase_Id" });
            DropIndex("dbo.Details_Purchase", new[] { "Product_Id" });
            DropIndex("dbo.Cashes", new[] { "cash_Id" });
            DropColumn("dbo.Users", "rol_Id");
            DropColumn("dbo.Categories", "Description");
            CreateIndex("dbo.Rols", "rol_ID");
            CreateIndex("dbo.Sales", "user_ID");
            CreateIndex("dbo.Sales", "cash_Flow_ID");
            CreateIndex("dbo.Sale_detail", "Sale_ID");
            CreateIndex("dbo.Sale_detail", "Product_ID");
            CreateIndex("dbo.Refunds", "Sale_Detail_ID");
            CreateIndex("dbo.Loggs", "user_ID");
            CreateIndex("dbo.Purchases", "cash_Flow_ID");
            CreateIndex("dbo.Products", "Category_ID");
            CreateIndex("dbo.Details_Purchase", "Purchase_ID");
            CreateIndex("dbo.Details_Purchase", "Product_ID");
            CreateIndex("dbo.Cashes", "cash_ID");
        }
    }
}
