using MyStock.Core.Entities.Base;
using MyStock.Core.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyStock.Core.Entities
{
    public class BrandEntity : BaseEntity<int>, IBrand
    {
        public BrandEntity()
        {
            Product = new List<ProductEntity>();
        }

        public string Name { get; set; }

        [JsonIgnore, IgnoreDataMember]
        public virtual List<ProductEntity> Product { get; set; }
    }
}
