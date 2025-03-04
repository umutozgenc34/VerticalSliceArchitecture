using Shared.Repositories;
using VerticalSliceArchitecture.Api.Features.Categories;

namespace VerticalSliceArchitecture.Api.Features.Products;

public class Product : BaseEntity<int>
{
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; } = default!;
}
