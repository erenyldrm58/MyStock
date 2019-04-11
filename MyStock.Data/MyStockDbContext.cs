using MyStock.Common.Helper;
using MyStock.Core.Entities;
using MyStock.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStock.Data
{
    public class MyStockDbContext : DbContext
    {
        public MyStockDbContext() : base(HelperSettings.GetConnectionString())
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MyStockDbContext>());

            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<BrandEntity> Brand { get; set; }
        public DbSet<CustomerEntity> Customer { get; set; }
        public DbSet<EmployeeEntity> Employee { get; set; }
        public DbSet<OrderEntity> Order { get; set; }
        public DbSet<ProductEntity> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new BrandConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
