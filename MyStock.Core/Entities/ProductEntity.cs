using MyStock.Core.Entities.Base;
using MyStock.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStock.Core.Entities
{
    public class ProductEntity : BaseEntity<int>, IProduct
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal Kdv { get; set; }
        public decimal SalePrice { get; set; }

        public int IDBrand { get; set; }
        public int IDOrder { get; set; }

        public virtual BrandEntity Brand { get; set; }
        public virtual OrderEntity Order { get; set; }
    }
}
