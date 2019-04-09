using MyStock.Core.Interfaces.Base;

namespace MyStock.Core.Interfaces
{
    public interface IEmployee : IBase<int>
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Phone { get; set; }
        string Address { get; set; }
        decimal Salary { get; set; }
        string Photo { get; set; }
    }
}
