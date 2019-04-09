using MyStock.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStock.Data.Configurations
{
    public class EmployeeConfiguration : EntityTypeConfiguration<EmployeeEntity>
    {
        public EmployeeConfiguration()
        {
            ToTable("EmployeeTable");

            HasKey(q => q.ID);

            Property(q => q.FirstName).IsRequired().HasMaxLength(50);
            Property(q => q.LastName).IsRequired().HasMaxLength(50);
            Property(q => q.Phone).IsRequired().HasMaxLength(10);
            Property(q => q.Address).IsRequired().HasMaxLength(250);
            Property(q => q.Salary).IsRequired();
        }
    }
}
