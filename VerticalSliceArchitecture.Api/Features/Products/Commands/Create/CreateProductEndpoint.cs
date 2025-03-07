using MediatR;
using Shared.Filters;

namespace VerticalSliceArchitecture.Api.Features.Products.Commands.Create;
public static class CreateProductEndpoint
{
    public static RouteGroupBuilder CreateProductGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/", async (CreateProductCommand command, IMediator mediator) =>
            await mediator.Send(command))
            .WithName("CreateProduct")
            .AddEndpointFilter<ValidationFilter<CreateProductCommand>>();

        return group;
    }
}