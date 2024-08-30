using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBL
{
    public interface ICourseBL
    {
        public CourseDTO Get(int id);
        public List<CourseDTO> GetAll(Func<CourseDTO, bool>? condition = null);
        public bool Add(CourseDTO item);
        public bool Update(CourseDTO item);
        public bool Delete(int id);
    }
}
