using MyStock.Core.Entities.Base;
using MyStock.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStock.Core.Entities
{
    public class OrderEntity : BaseEntity<int>, IOrder
    {
        public OrderEntity()
        {
            Product = new List<ProductEntity>();
        }

        public int Count { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Discount { get; set; }

        public int IDCustomer { get; set; }
        public int IDEmployee { get; set; }

        public virtual CustomerEntity Customer { get; set; }
        public virtual EmployeeEntity Employee { get; set; }
        public virtual List<ProductEntity> Product { get; set; }
    }
}
