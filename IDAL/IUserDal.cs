using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IUserDal
    {
        public UserDTO Get(int id);
        public List<UserDTO> GetAll(Func<UserDTO, bool>? condition = null);
        public bool Add(UserDTO item);
        public bool Update(UserDTO item);
        public bool Delete(int id);
    }
}
