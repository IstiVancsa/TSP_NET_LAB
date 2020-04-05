namespace CodeFirstEF.DBContexts
{
    using CodeFirstEF.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Scenariu4DBContext : DbContext
    {
        // Your context has been configured to use a 'Scenariu4DBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirstEF.Scenariu4DBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Scenariu4DBContext' 
        // connection string in the application configuration file.
        public Scenariu4DBContext()
            : base("name=Scenariu4DBContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Business> Businesses { get; set; }
    }
}