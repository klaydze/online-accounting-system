using System;

namespace Accounting.Domain.Interfaces
{
    public interface IAuditableEntity
    {
        Guid CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }

        Guid UpdatedBy { get; set; }
        DateTime UpdatedDate { get; set; }

        byte[] RowVersion { get; set; }
    }
}