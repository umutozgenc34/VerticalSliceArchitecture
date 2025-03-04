using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VerticalSliceArchitecture.Api.Features.Products;

namespace VerticalSliceArchitecture.Api.Persistence;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products"); 

        builder.HasKey(p => p.Id); 

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(200); 

        builder.Property(p => p.Price)
            .IsRequired()
            .HasPrecision(18,2); 

        builder.HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict); 
    }
}