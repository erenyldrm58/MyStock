using MyStock.Core.Interfaces.Base;

namespace MyStock.Core.Interfaces
{
    public interface IBrand : IBase<int>
    {
        string Name { get; set; }
    }
}
