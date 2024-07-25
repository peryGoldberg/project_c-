using System;
using System.Collections.Generic;

namespace Dal_Repository.Model
{
    public partial class User
    {
        public User()
        {
            Appointments = new HashSet<Appointment>();
            GroupPermissions = new HashSet<GroupPermission>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string? Email { get; set; }
        public string PasswordHash { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<GroupPermission> GroupPermissions { get; set; }
    }
}
