namespace ControlTienda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cash_Flow",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(),
                        income_amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        disbursement_amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cashes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        unit_amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        total_amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        Remark = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Details_Purchase",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        date_hour = c.DateTime(),
                        quantity = c.Int(nullable: false),
                        Unit_Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        total_amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Loggs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date_Hour_entry = c.DateTime(),
                        Date_Hour_exit = c.DateTime(),
                        Remark = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BarCode = c.String(maxLength: 25),
                        Name = c.String(maxLength: 150),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date_Hour = c.DateTime(),
                        Remark = c.String(maxLength: 250),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Refunds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        observations = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rols",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 25),
                        Details = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sale_detail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date_Hour = c.DateTime(),
                        quantity = c.Int(nullable: false),
                        unit_amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        total_amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        date_hour = c.DateTime(),
                        Quantity = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Address = c.String(maxLength: 100),
                        Phone = c.String(maxLength: 25),
                        Nickname = c.String(maxLength: 8),
                        Password = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Sales");
            DropTable("dbo.Sale_detail");
            DropTable("dbo.Rols");
            DropTable("dbo.Refunds");
            DropTable("dbo.Purchases");
            DropTable("dbo.Products");
            DropTable("dbo.Loggs");
            DropTable("dbo.Details_Purchase");
            DropTable("dbo.Categories");
            DropTable("dbo.Cashes");
            DropTable("dbo.Cash_Flow");
        }
    }
}
