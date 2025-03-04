namespace VerticalSliceArchitecture.Api.Features.Products;

public static class ProductEndpointExtension
{
    public static void AddProductGroupEndpointExtension(this WebApplication app)
    {
        app.MapGroup("api/products");
    }
}
