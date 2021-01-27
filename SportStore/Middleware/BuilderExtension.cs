using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Middleware
{
    public static class BuilderExtension
    {
        public static IApplicationBuilder UseTimeMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<TimeMiddleware>();
        }
    }
}
