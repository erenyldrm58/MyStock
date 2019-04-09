using MyStock.Core.Entities.Base;
using MyStock.Core.Interfaces;
using System.Collections.Generic;

namespace MyStock.Core.Entities
{
    public class CustomerEntity : BaseEntity<int>, ICustomer
    {
        public CustomerEntity()
        {
            OrderList = new List<OrderEntity>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public decimal Dept { get; set; }

        public virtual OrderEntity Order { get; set; }
        public virtual List<OrderEntity> OrderList { get; set; }
    }
}
