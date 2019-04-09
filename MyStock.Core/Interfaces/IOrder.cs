using MyStock.Core.Interfaces.Base;
using System;

namespace MyStock.Core.Interfaces
{
    public interface IOrder : IBase<int>
    {
        int Count { get; set; }
        DateTime OrderDate { get; set; }
        decimal Discount { get; set; }
    }
}
