using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VerticalSliceArchitecture.Api.Features.Categories;
using VerticalSliceArchitecture.Api.Features.Products;

namespace VerticalSliceArchitecture.Api.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
