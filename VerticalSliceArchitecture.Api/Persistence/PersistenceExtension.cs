using Microsoft.EntityFrameworkCore;

namespace VerticalSliceArchitecture.Api.Persistence;

public static class PersistenceExtension
{
    public static IServiceCollection AddPersistenceExtension(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("MsSql"));
        });

        return services;
    }
}
