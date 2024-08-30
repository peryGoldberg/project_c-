using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface ICategoryDal
    {
        public CategoryDTO Get(int id);
        public List<CategoryDTO> GetAll(Func<CategoryDTO, bool>? condition = null);
        public bool Add(CategoryDTO item);
        public bool Update(CategoryDTO item);
        public bool Delete(int id);
    }
}
