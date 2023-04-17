using Package.Infrastructure.Interfaces;
using Package.Infrastructure.Services;

namespace Package.Api.Extensions;
public static class ApplicationServices
{
    public static void LoadServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IDHL, DHL>();
    }
}