using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public static class DalCommon
    {
        public static IServiceCollection AddDalDependencies(this IServiceCollection collection)
        {
            collection.AddScoped(typeof(IDAL.IUserDal),typeof(Dal_Repository.UserDal));
            return collection;
        }
        
    }
}
