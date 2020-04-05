namespace CodeFirstEF.DBContexts
{
    using CodeFirstEF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public class ModelSelfReferences : DbContext
    {
        // Your context has been configured to use a 'ModelSelfReferences' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirstEF.ModelSelfReferences' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelSelfReferences' 
        // connection string in the application configuration file.
        public ModelSelfReferences()
            : base("name=ModelSelfReferences")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<SelfReference> SelfReferences { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.Entity<SelfReference>()
                        .HasMany(m => m.References).WithOptional(m => m.ParentSelfReference);
        }

        public async Task<SelfReference> GetDataById(Expression<Func<SelfReference, bool>> filter)
        {
            return await this.SelfReferences.Where(filter).FirstOrDefaultAsync();
        }

        public async Task<List<SelfReference>> GetAllData()//expression<Func<
        {
            return await this.SelfReferences.ToListAsync();
        }

        public async Task InsertItem(SelfReference item)
        {
            this.SelfReferences.Add(item);
            await this.SaveChangesAsync();
        }
    }
}