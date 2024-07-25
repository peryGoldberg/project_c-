using System;
using System.Collections.Generic;

namespace Dal_Repository.Model
{
    public partial class AppointmentType
    {
        public AppointmentType()
        {
            Doctors = new HashSet<Doctor>();
        }

        public int AppointmentTypeId { get; set; }
        public string TypeName { get; set; } = null!;

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
