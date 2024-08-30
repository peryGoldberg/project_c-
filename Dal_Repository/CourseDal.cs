using AutoMapper;
using Dal_Repository.Model;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public class CourseDal:IDAL.ICourseDal
    {
        public bool Add(CourseDTO item)
        {
            try
            {
                using Model.LearningPlatformContext ctx = new();
                Mapper.Initialize(
                   cnf =>
                   cnf.CreateMap<Course, CourseDTO>()
                   .ReverseMap()
                   );
                Course u = Mapper.Map<Course>(item);
                ctx.Add(u);
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
                using Model.LearningPlatformContext ctx = new();
                Course user = ctx.Courses.Find(id);
                ctx.Courses.Remove(user);
                ctx.SaveChanges();
                return true;
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
                using Model.LearningPlatformContext ctx = new();
                Mapper.Initialize(
                    cnf =>
                    cnf.CreateMap<Course, CourseDTO>()
                    .ReverseMap()
                    );
                CourseDTO u = Mapper.Map<CourseDTO>(ctx.Courses.Find(id));
                return u;
                //object user = ctx.Users.Find(id);
                //return user;
            }
            catch
            {
                return null;
            }
        }

        public List<CourseDTO> GetAll(Func<CourseDTO, bool>? condition = null)
        {
            try
            {
                using Model.LearningPlatformContext ctx = new();
                Mapper.Initialize(
                    cnf =>
                    cnf.CreateMap<Course, CourseDTO>()
                    .ReverseMap()
                    );
                return ctx.Courses.Select(u => Mapper.Map<CourseDTO>(u)).ToList();
            }
            catch
            {
                return null;
            }
        }



        public bool Update(CourseDTO item)
        {
            try
            {
                using Model.LearningPlatformContext ctx = new();
                Mapper.Initialize(
                   cnf =>
                   cnf.CreateMap<Course, CourseDTO>()
                   .ReverseMap()
                   );
                Course u = Mapper.Map<Course>(item);
                ctx.Courses.Update(u);
                int changes = ctx.SaveChanges();
                return changes > 0;
            }
            catch
            {
                return false;
            }
        }

    }
}
