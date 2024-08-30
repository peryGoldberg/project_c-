using DTO;
using IBL;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl_Services
{
    public class CourseBL:IBL.ICourseBL
    {
        private readonly IDAL.ICourseDal ICourseDal;

        public CourseBL(ICourseDal _ICourseDal)
        {
            ICourseDal = _ICourseDal;
        }

        public bool Add(CourseDTO item)
        {
            try
            {
                return ICourseDal.Add(item);
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
                return ICourseDal.Delete(id);
            }
            catch
            {
                return false;
            }

        }

        public CourseDTO Get(int id)
        {
            try
            {
                return ICourseDal.Get(id);
            }
            catch
            {
                return null;
            }

        }
        List<CourseDTO> ICourseBL.GetAll(Func<CourseDTO, bool>? condition)
        {
            try
            {
                return ICourseDal.GetAll();
            }
            catch
            {
                return null;
            }
        }



        public bool Update(CourseDTO course)
        {
            return ICourseDal.Update(course);
        }
    }
}
