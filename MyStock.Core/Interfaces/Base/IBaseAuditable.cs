using System;
using System.Collections.Generic;
using System.Text;

namespace MyStock.Core.Interfaces.Base
{
    public interface IBaseAuditable
    {

        DateTimeOffset? CreatedDateOffsetUtc { get; set; }

        string CreatedBy { get; set; }

        DateTimeOffset? UpdatedDateOffsetUtc { get; set; }

        string UpdatedBy { get; set; }

        bool IsDeletable { get; set; }

        DateTimeOffset? DeletionDateOffsetUtc { get; set; }

    }
}
