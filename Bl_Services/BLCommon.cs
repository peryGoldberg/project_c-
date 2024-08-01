
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bl_Services
{
    public static class BLCommon
    {
        public static IServiceCollection AddBLDependencies(this IServiceCollection collection)
        {
            collection.AddScoped(typeof(IBL.Ibl), typeof(Bl_Services.UserBL));
            return collection;
        }
    }
}
