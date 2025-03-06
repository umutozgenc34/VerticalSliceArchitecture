using VerticalSliceArchitecture.Api.Features.Categories.Commands.Create;

namespace VerticalSliceArchitecture.Api.Features.Categories;

public static class CategoryEndpointExtension
{
    public static void AddCategoryGroupEndpointExtension(this WebApplication app)
    {
        var group = app.MapGroup("api/categories"); 
        group.CreateCategoryGroupItemEndpoint();
    }
}
