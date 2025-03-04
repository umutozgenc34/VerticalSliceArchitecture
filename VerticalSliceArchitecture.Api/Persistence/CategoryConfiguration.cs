using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VerticalSliceArchitecture.Api.Features.Categories;

namespace VerticalSliceArchitecture.Api.Persistence;
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories"); 

        builder.HasKey(x => x.Id); 

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100); 

        builder.HasMany(x => x.Products)
            .WithOne(x => x.Category)
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.Cascade); 
    }
}