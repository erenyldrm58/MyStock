using MyStock.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MyStock.Data.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<ProductEntity>
    {
        public ProductConfiguration()
        {
            ToTable("ProductTable");

            HasKey(q => q.ID);

            Property(q => q.Name).IsRequired().HasMaxLength(150);
            Property(q => q.BuyingPrice).IsRequired();
            Property(q => q.Count).IsRequired();
            Property(q => q.Kdv).IsRequired();
            Property(q => q.SalePrice).IsRequired();

            HasRequired(q => q.Brand).WithMany(q => q.Product).HasForeignKey(q => q.IDBrand);
            HasRequired(q => q.Order).WithMany(q => q.Product).HasForeignKey(q => q.IDOrder);
        }
    }
}
