using Microsoft.EntityFrameworkCore;
using VerticalSliceArchitecture.Api.Features.Categories.Interfaces;
using VerticalSliceArchitecture.Api.Features.Products.Interfaces;

namespace VerticalSliceArchitecture.Api.Persistence;

public static class PersistenceExtension
{
    public static IServiceCollection AddPersistenceExtension(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("MsSql"));
        });

        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
