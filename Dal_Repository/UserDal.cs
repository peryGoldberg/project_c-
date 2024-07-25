using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal_Repository.Model;
using IDAL;

namespace Dal_Repository
{
    public class UserDal : IDAL.IDal
    {
        public bool Add(object item)
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
                User user = ctx.Users.Find(id);
                ctx.Users.Remove(user);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public object Get(int id)
        {
            try
            {
                using Model.ProjectContext ctx = new();
                object user = ctx.Users.Find(id);
                return user;
            }
            catch
            {
                return null;
            }
        }

        public List<object> GetAll(Func<object, bool>? condition = null)
        {
            try
            {
                using Model.ProjectContext ctx = new();
                if (condition != null)
                    return ctx.Users.Where(condition).ToList();
                else
                    return ctx.Users.Select (u=>u as object ).ToList();
            }
            catch
            {
                return null;
            }
        }



        public bool Update(object item)
        {
            try
            {
                using Model.ProjectContext ctx = new();
                ctx.Users.Attach(item as User);
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
