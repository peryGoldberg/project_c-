using Microsoft.AspNetCore.Builder;
using System.Diagnostics;
using System.Globalization;

namespace WebApi
{
    public class castomMiddleWAre
    {
        private readonly RequestDelegate next;

        public castomMiddleWAre(RequestDelegate @delegate)
        {
            next = @delegate;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                await httpContext.Response.WriteAsync("****  CurrentCulture.DisplayName:  {CultureInfo.CurrentCulture.DisplayName}");
                return;

            }
            await next(httpContext);

        }

    }

    public static class CastommiddleWare
    {
        public static IApplicationBuilder UseCastommiddleWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<castomMiddleWAre>();
        }
    }
}
