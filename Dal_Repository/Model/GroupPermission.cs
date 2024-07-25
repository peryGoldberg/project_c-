using System;
using System.Collections.Generic;

namespace Dal_Repository.Model
{
    public partial class GroupPermission
    {
        public int GroupPermissionId { get; set; }
        public int Users { get; set; }
        public int? UserId { get; set; }
        public int PermissionId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Permission Permission { get; set; } = null!;
        public virtual User? User { get; set; }
    }
}
