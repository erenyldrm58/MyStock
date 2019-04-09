using MyStock.Core.Interfaces.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyStock.Core.Entities.Base
{
    public abstract class BaseAuditableEntity : IBaseAuditable
    {
        private DateTimeOffset? _createdDateOffsetUtc;

        private bool? _isDeletable;

        [ScaffoldColumn(false)]
        public DateTimeOffset? CreatedDateOffsetUtc { get => _createdDateOffsetUtc ?? DateTimeOffset.UtcNow; set => _createdDateOffsetUtc = value; }

        [ScaffoldColumn(false)]
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTimeOffset? UpdatedDateOffsetUtc { get; set; }

        [ScaffoldColumn(false)]
        public string UpdatedBy { get; set; }

        [ScaffoldColumn(false)]
        public bool IsDeletable { get => _isDeletable ?? false; set => _isDeletable = value; }

        [ScaffoldColumn(false)]
        public DateTimeOffset? DeletionDateOffsetUtc { get; set; }
    }
}
