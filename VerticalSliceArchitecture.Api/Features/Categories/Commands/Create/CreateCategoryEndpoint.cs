using MediatR;
using Shared.Filters;

namespace VerticalSliceArchitecture.Api.Features.Categories.Commands.Create;

public static class CreateCategoryEndpoint
{
    public static RouteGroupBuilder CreateCategoryGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/", async (CreateCategoryCommand command, IMediator mediator) =>
            await mediator.Send(command))
            .WithName("CreateCategory")
            .AddEndpointFilter<ValidationFilter<CreateCategoryCommand>>();

        return group;
    }
}