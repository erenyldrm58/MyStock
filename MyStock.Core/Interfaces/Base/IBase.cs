using System;
using System.Collections.Generic;
using System.Text;

namespace MyStock.Core.Interfaces.Base
{
    public interface IBase
    {

    }

    public interface IBase<TKey>
    {
        TKey ID { get; set; }
    }
}
