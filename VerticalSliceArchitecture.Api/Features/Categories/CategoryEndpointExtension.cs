using VerticalSliceArchitecture.Api.Features.Categories.Commands.Create;
using VerticalSliceArchitecture.Api.Features.Categories.Queries.GetAll;

namespace VerticalSliceArchitecture.Api.Features.Categories;

public static class CategoryEndpointExtension
{
    public static void AddCategoryGroupEndpointExtension(this WebApplication app)
    {
        var group = app.MapGroup("api/categories").WithTags("Categories");
        group.CreateCategoryGroupItemEndpoint();
        group.GetAllCategoriesGroupItemEndpoint();
    }
}
