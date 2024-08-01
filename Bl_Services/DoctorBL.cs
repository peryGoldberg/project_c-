//using Dal_Repository.Model;
//using Dal_Repository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bl_Services
//{
//    public class DoctorBL
//    {
//        public bool Add(Doctor item)
//        {
//            try
//            {
//                return new DoctorDal().Add(item);
//            }
//            catch
//            {
//                return false;
//            }

//        }

//        public bool Delete(int id)
//        {
//            try
//            {
//                return new DoctorDal().Delete(id);
//            }
//            catch
//            {
//                return false;
//            }

//        }

//        public Doctor Get(int id)
//        {
//            try
//            {
//                return new DoctorDal().Get(id);
//            }
//            catch
//            {
//                return null;
//            }

//        }

//        public List<Doctor> GetAll(Func<Doctor, bool>? condition = null)
//        {
//            try
//            {
//                return new DoctorDal().GetAll(condition);
//            }
//            catch
//            {
//                return null;
//            }
//        }

//        public bool Update(Doctor doctor)
//        {
//            return new DoctorDal().Update(doctor);
//        }
//    }
//}

