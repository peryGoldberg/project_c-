
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl_Services
{
    public class UserBL
    {
        private readonly IDAL.IDal IUserDal;

        public UserBL(IDal iUserDal)
        {
            IUserDal = iUserDal;
        }

        public bool Add(object item)
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

        public object Get(int id)
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

        public List<object> GetAll(Func<object, bool>? condition = null)
        {
            try
            {
                return  IUserDal.GetAll(condition);
            }
            catch
            {
                return null;
            }
        }

        public bool Update(object user)
        {
            return  IUserDal.Update(user);
        }
    }
}
