using System;
using System.Collections.Generic;

namespace Dal_Repository.Model
{
    public partial class Appointment
    {
        public int AppointmentId { get; set; }
        public int UserId { get; set; }
        public int DoctorId { get; set; }
        public DateTime? AppointmentDateTime { get; set; }

        public virtual Doctor Doctor { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
