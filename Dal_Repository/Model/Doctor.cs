using System;
using System.Collections.Generic;

namespace Dal_Repository.Model
{
    public partial class Doctor
    {
        public Doctor()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int DoctorId { get; set; }
        public string? DoctorName { get; set; }
        public int? Specialization { get; set; }

        public virtual AppointmentType? SpecializationNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
