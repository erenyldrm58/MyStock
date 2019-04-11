using MyStock.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MyStock.Data.Configurations
{
    public class OrderConfiguration : EntityTypeConfiguration<OrderEntity>
    {
        public OrderConfiguration()
        {
            ToTable("OrderTable");

            HasKey(q => q.ID);
            Property(q => q.Count).IsRequired();

            HasRequired(q => q.Customer).WithMany(q => q.OrderList).HasForeignKey(q => q.IDCustomer);
            HasRequired(q => q.Employee).WithRequiredPrincipal(q => q.Order);
        }
    }
}
