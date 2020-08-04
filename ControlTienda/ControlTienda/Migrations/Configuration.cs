namespace ControlTienda.Migrations
{
    using ControlTienda.Data;
    using ControlTienda.Data.Entities;
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
            Rol rol = new Rol();
            rol.Name = "Admin";
            rol.Details = "es la categoria mas alta en la jerarquia de trabajo,tiene acceso ilimitado";
            context.rols.Add(rol);
            context.SaveChanges();

            User user = new User();
            user.Name = "Admin";
            user.Nickname = "administrador";
            user.Password = "Admin";
            context.users.Add(user);
            context.SaveChanges();
            //context.rols.Add(new Rol() { Name = "Admin", Details="Min Admin of the System  with full permissions" });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
