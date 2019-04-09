using MyStock.Core.Interfaces.Base;

namespace MyStock.Core.Interfaces
{
    public interface IProduct : IBase<int>
    {
        string Name { get; set; }
        int Count { get; set; }
        decimal BuyingPrice { get; set; }
        decimal Kdv { get; set; }
        decimal SalePrice { get; set; }
    }
}
