using MyStock.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MyStock.Data.Configurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<CustomerEntity>
    {
        public CustomerConfiguration()
        {
            ToTable("CustomerTable");

            HasKey(q => q.ID);

            Property(q => q.FirstName).IsRequired().HasMaxLength(50);
            Property(q => q.LastName).IsRequired().HasMaxLength(50);
            Property(q => q.Phone).IsRequired().HasMaxLength(10);
            Property(q => q.Address).IsRequired().HasMaxLength(250);
        }
    }
}
