namespace ControlTienda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seeder3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", new[] { "rol_Id" });
            AlterColumn("dbo.Users", "Nickname", c => c.String(maxLength: 200));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 200));
            CreateIndex("dbo.Users", "Rol_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Rol_Id" });
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 15));
            AlterColumn("dbo.Users", "Nickname", c => c.String(maxLength: 8));
            CreateIndex("dbo.Users", "rol_Id");
        }
    }
}
