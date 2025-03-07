using MediatR;

namespace VerticalSliceArchitecture.Api.Features.Products.Queries.GetAll;

public static class GetAllProductsEndpoint
{
    public static RouteGroupBuilder GetAllProductsGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/", async (IMediator mediator) =>
            await mediator.Send(new GetAllProductsQuery()))
            .WithName("GetAllProducts");

        return group;
    }
}