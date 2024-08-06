using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dal_Repository.Model;
using DTO;
using IDAL;

namespace Dal_Repository
{
    public class UserDal : IDAL.IUserDal
    {
        public bool Add(UserDTO item)
        {
            try
            {
                using Model.ProjectContext ctx = new();
                Mapper.Initialize(
                   cnf =>
                   cnf.CreateMap<User, UserDTO>()
                   .ReverseMap()
                   );
                User u = Mapper.Map<User>(item);
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

        public UserDTO Get(int id)
        {
            try
            {
                using Model.ProjectContext ctx = new();
                Mapper.Initialize(
                    cnf =>
                    cnf.CreateMap<User, UserDTO>()
                    .ReverseMap()
                    );
                UserDTO u=Mapper.Map<UserDTO>(ctx.Users.Find(id));
                return u;
                //object user = ctx.Users.Find(id);
                //return user;
            }
            catch
            {
                return null;
            }
        }

        public List<UserDTO> GetAll(Func<UserDTO, bool>? condition = null)
        {
            try
            {
                using Model.ProjectContext ctx = new();
                Mapper.Initialize(
                    cnf=>
                    cnf.CreateMap<User, UserDTO>()
                    .ReverseMap()
                    );
                    return ctx.Users.Select (u=> Mapper.Map<UserDTO >(u) ).ToList();
            }
            catch
            {
                return null;
            }
        }

        

        public bool Update(UserDTO item)
        {
            try
            {
                using Model.ProjectContext ctx = new();
                Mapper.Initialize(
                   cnf =>
                   cnf.CreateMap<User, UserDTO>()
                   .ReverseMap()
                   );
                User u = Mapper.Map<User>(item);
                ctx.Users.Attach(u);
                
                return true;
            }
            catch
            {
                return false;
            }
        }

       
    }
}
