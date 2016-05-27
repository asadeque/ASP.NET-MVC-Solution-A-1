namespace Assignment1.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment1.Models.ProductDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assignment1.Models.ProductDBContext context)
        {
            context.Products.AddOrUpdate(i => i.Title,
                new Product
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },

                 new Product
                 {
                     Title = "Ghostbusters ",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Price = 8.99M
                 },

                 new Product
                 {
                     Title = "Ghostbusters 2",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Price = 9.99M
                 },

               new Product
               {
                   Title = "Rio Bravo",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Price = 3.99M
               }
           );

        }
    }
}
