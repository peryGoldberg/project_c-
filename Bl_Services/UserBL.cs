
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
    public class UserBL: IBL.IUserBL
    {
        private readonly IDAL.IUserDal IUserDal;

        public UserBL(IUserDal iUserDal)
        {
            IUserDal = iUserDal;
        }

        public bool Add(UserDTO item)
        {
            try
            {
                return IUserDal.Add(item);
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
                return  IUserDal.Delete(id);
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
                 return  IUserDal.Get(id);
            }
            catch
            {
                return null;
            }
           
        }
        List<UserDTO> IUserBL.GetAll(Func<UserDTO, bool>? condition)
        {
            try
            {
                return  IUserDal.GetAll();
            }
            catch
            {
                return null;
            }
        }

       

        public bool Update(UserDTO user)
        {
            return  IUserDal.Update(user);
        }

       

       
    }
}
