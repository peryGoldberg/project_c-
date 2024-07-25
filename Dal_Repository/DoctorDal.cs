using Dal_Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public class DoctorDal : ICRUD<Model.Doctor>
    {
        public bool Add(Doctor item)
        {
            try
            {
                using Model.ProjectContext ctx = new();
                ctx.Add(item);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using Model.ProjectContext ctx = new();
                Doctor doctor = ctx.Doctors.Find(id);
                ctx.Doctors.Remove(doctor);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Doctor Get(int id)
        {
            try
            {
                using Model.ProjectContext ctx = new();
                Doctor doctor = ctx.Doctors.Find(id);
                return doctor;
            }
            catch
            {
                return null;
            }
        }

        public List<Doctor> GetAll(Func<Doctor, bool>? condition = null)
        {
            try
            {
                using Model.ProjectContext ctx = new();
                if (condition != null)
                    return ctx.Doctors.Where(condition).ToList();
                else
                    return ctx.Doctors.ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool Update(Doctor item)
        {
            try
            {
                using Model.ProjectContext ctx = new();
                ctx.Doctors.Attach(item);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
