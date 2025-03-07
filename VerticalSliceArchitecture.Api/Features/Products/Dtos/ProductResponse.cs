namespace VerticalSliceArchitecture.Api.Features.Products.Dtos;

public sealed record ProductResponse
{
    public string Name { get; init; } 
    public decimal Price { get; init; }
    public int CategoryId { get; init; }
}
