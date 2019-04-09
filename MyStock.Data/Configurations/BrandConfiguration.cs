using MyStock.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MyStock.Data.Configurations
{
    public class BrandConfiguration : EntityTypeConfiguration<BrandEntity>
    {
        public BrandConfiguration()
        {
            ToTable("BrandTable");

            HasKey(q => q.ID);
            Property(q => q.Name).IsRequired().HasMaxLength(50);
        }
    }
}
