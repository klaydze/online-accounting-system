using Accounting.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Domain.Entities
{
    public class UserLevelAccess : IAuditableEntity
    {
[LevelID_fk] [bigint] NULL,
	[ModuleID_fk] [bigint] NULL,
	[CanAdd] [bit] NULL,
	[CanEdit] [bit] NULL,
	[CanDelete] [bit] NULL,
	[CanView] [bit] NULL,
	[CanPrint] [bit] NULL,



        [Key]
        public Guid UserLevelAccessID { get; set; }

        public Guid UserLevelID { get; set; }

        public Guid ModuleID { get; set; }

        [Column(TypeName = "varchar(5)")]
        public bool CanAdd { get; set; }

        [Column(TypeName = "varchar(100)")]
        public String Category { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String Description { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}