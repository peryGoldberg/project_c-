using System;
using System.Collections.Generic;

namespace Dal_Repository.Model
{
    public partial class Permission
    {
        public Permission()
        {
            GroupPermissions = new HashSet<GroupPermission>();
        }

        public int PermissionId { get; set; }
        public string PermissionName { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<GroupPermission> GroupPermissions { get; set; }
    }
}
