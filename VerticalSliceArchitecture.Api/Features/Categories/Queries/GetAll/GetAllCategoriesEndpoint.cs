using MediatR;

namespace VerticalSliceArchitecture.Api.Features.Categories.Queries.GetAll;

public static class GetAllCategoriesEndpoint
{
    public static RouteGroupBuilder GetAllCategoriesGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/", async (IMediator mediator) =>
            await mediator.Send(new GetAllCategoriesQuery()))
            .WithName("GetAllCategories");

        return group;
    }
}