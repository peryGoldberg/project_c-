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
    public class CategoryBL:IBL.ICategoryBL
    {
        private readonly IDAL.ICategoryDal ICategoryDal;

        public CategoryBL(ICategoryDal _IcategoryDal)
        {
            ICategoryDal = _IcategoryDal;
        }

        public bool Add(CategoryDTO item)
        {
            try
            {
                return ICategoryDal.Add(item);
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
                return ICategoryDal.Delete(id);
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
                return ICategoryDal.Get(id);
            }
            catch
            {
                return null;
            }

        }
        List<CategoryDTO> ICategoryBL.GetAll(Func<CategoryDTO, bool>? condition)
        {
            try
            {
                return ICategoryDal.GetAll();
            }
            catch
            {
                return null;
            }
        }



        public bool Update(CategoryDTO user)
        {
            return ICategoryDal.Update(user);
        }

    }
}
