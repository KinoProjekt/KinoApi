using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace KinoApi.Middleware
{
    public class ErrorHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            catch (System.Exception)
            {

                throw;
            }
            // Wszystkie exceptiony
        }
    }
}
