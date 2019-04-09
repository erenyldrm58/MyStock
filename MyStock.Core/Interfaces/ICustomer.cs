using MyStock.Core.Interfaces.Base;

namespace MyStock.Core.Interfaces
{
    public interface ICustomer : IBase<int>
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Phone { get; set; }
        string Address { get; set; }
        decimal Dept { get; set; }
    }
}
