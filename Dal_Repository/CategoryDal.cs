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
    public class CategoryDal : IDAL.ICategoryDal
    {
        public bool Add(CategoryDTO item)
        {
            try
            {
                using Model.LearningPlatformContext ctx = new();
                Mapper.Initialize(
                   cnf =>
                   cnf.CreateMap<Category, CategoryDTO>()
                   .ReverseMap()
                   );
                Category u = Mapper.Map<Category>(item);
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
                Category user = ctx.Categories.Find(id);
                ctx.Categories.Remove(user);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public CategoryDTO Get(int id)
        {
            try
            {
                using Model.LearningPlatformContext ctx = new();
                Mapper.Initialize(
                    cnf =>
                    cnf.CreateMap<Category, CategoryDTO>()
                    .ReverseMap()
                    );
                CategoryDTO u = Mapper.Map<CategoryDTO>(ctx.Categories.Find(id));
                return u;
                //object user = ctx.Users.Find(id);
                //return user;
            }
            catch
            {
                return null;
            }
        }

        public List<CategoryDTO> GetAll(Func<CategoryDTO, bool>? condition = null)
        {
            try
            {
                using Model.LearningPlatformContext ctx = new();
                Mapper.Initialize(
                    cnf =>
                    cnf.CreateMap<Category, CategoryDTO>()
                    .ReverseMap()
                    );
                return ctx.Categories.Select(u => Mapper.Map<CategoryDTO>(u)).ToList();
            }
            catch
            {
                return null;
            }
        }



        public bool Update(CategoryDTO item)
        {
            try
            {
                using Model.LearningPlatformContext ctx = new();
                Mapper.Initialize(
                   cnf =>
                   cnf.CreateMap<Category, CategoryDTO>()
                   .ReverseMap()
                   );
                Category u = Mapper.Map<Category>(item);
                ctx.Categories.Update(u);
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
