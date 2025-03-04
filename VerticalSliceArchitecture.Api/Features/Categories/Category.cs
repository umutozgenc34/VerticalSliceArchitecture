using Shared.Repositories;
using VerticalSliceArchitecture.Api.Features.Products;

namespace VerticalSliceArchitecture.Api.Features.Categories;

public class Category : BaseEntity<int>
{
    public string Name { get; set; }
    public List<Product> Products { get; set; } = new();
}
