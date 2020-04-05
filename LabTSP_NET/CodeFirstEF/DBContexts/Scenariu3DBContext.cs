namespace CodeFirstEF.DBContexts
{
    using CodeFirstEF.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Scenariu3DBContext : DbContext
    {
        // Your context has been configured to use a 'Scenariu3DBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirstEF.Scenariu3DBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Scenariu3DBContext' 
        // connection string in the application configuration file.
        public Scenariu3DBContext()
            : base("name=Scenariu3DBContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Photograph> Photographs { get; set; }
        public virtual DbSet<PhotographFullImage> PhotographFullImages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photograph>()
            .HasRequired(p => p.PhotographFullImage)
            .WithRequiredPrincipal(p => p.Photograph);
            modelBuilder.Entity<Photograph>()
            .ToTable("Photograph", "BazaDeDate");
            modelBuilder.Entity<PhotographFullImage>()
            .ToTable("Photograph", "BazaDeDate");
        }
    }
}