namespace ControlTienda.Migrations
{
    using ControlTienda.Data;
    using ControlTienda.Data.Entities;
    using ControlTienda.Encrypt;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
       
        protected override void Seed(DataContext context)
        {
            Encrypting encrypting = new Encrypting();
            Rol rol = new Rol();         
            User user = new User();
            if(context.rols ==null && context.users == null)
            {
                rol.Name = "Admin";
                rol.Details = "es la categoria mas alta en la jerarquia de trabajo,tiene acceso ilimitado";             
                context.rols.Add(rol);
                
                user.Name = "Admin";
                user.Nickname = "administrador";
                user.Password =encrypting.GetSha256("Admin");
                
                context.users.Add(user);
                context.SaveChanges();
            }

           
            //context.rols.Add(new Rol() { Name = "Admin", Details="Min Admin of the System  with full permissions" });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
