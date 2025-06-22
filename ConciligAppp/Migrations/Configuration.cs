namespace ConciligAppp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConciligAppp.Data1.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ConciligAppp.Data1.AppDbContext context)
        {
            if (!context.Usuarios.Any())
            {
                context.Usuarios.Add(new ConciligAppp.Models1.Usuario
                {
                    Nome = "Admin",
                    Email = "admin@gmail.com",
                    SenhaHash = "admin"
                });

                context.SaveChanges();
            }
        }
    }
}
