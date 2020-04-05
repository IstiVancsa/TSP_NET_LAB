namespace CodeFirstEF.DBContexts
{
    using CodeFirstEF.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Scenariu2DBContext : DbContext
    {
        // Your context has been configured to use a 'Scenariu2DBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirstEF.Scenariu2DBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Scenariu2DBContext' 
        // connection string in the application configuration file.
        public Scenariu2DBContext()
            : base("name=Scenariu2DBContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.Description, p.Price });
                m.ToTable("Product", "BazaDeDate");
            })
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.ImageURL });
                m.ToTable("ProductWebInfo", "BazaDeDate");
            });
        }
    }
}