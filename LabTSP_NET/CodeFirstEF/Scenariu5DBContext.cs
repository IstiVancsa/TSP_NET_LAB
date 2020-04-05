namespace CodeFirstEF
{
    using CodeFirstEF.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Scenariu5DBContext : DbContext
    {
        // Your context has been configured to use a 'Scenariu5DBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirstEF.Scenariu5DBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Scenariu5DBContext' 
        // connection string in the application configuration file.
        public Scenariu5DBContext()
            : base("name=Scenariu5DBContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
            .Map<FullTimeEmployee>(m => m.Requires("EmployeeType")
            .HasValue(1))
            .Map<HourlyEmployee>(m => m.Requires("EmployeeType")
            .HasValue(2));
        }
    }
}