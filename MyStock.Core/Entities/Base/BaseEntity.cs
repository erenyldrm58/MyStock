using MyStock.Core.Interfaces.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyStock.Core.Entities.Base
{
    public abstract class BaseEntity : BaseAuditableEntity, IBase
    {

    }

    public abstract class BaseEntity<TKey> : BaseEntity, IBase<TKey>
    {
        [Key]
        [Column(name: "ID", Order = 0)]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual TKey ID { get; set; }
    }
}
