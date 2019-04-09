using MyStock.Core.Entities.Base;
using MyStock.Core.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyStock.Core.Entities
{
    public class EmployeeEntity:BaseEntity<int>, IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public string Photo { get; set; }

        public virtual OrderEntity Order { get; set; }
    }
}