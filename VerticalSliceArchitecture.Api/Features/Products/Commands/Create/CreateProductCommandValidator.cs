using FluentValidation;

namespace VerticalSliceArchitecture.Api.Features.Products.Commands.Create;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(200).WithMessage("Name must not exceed 200 characters.");

        RuleFor(x => x.Price)
            .NotEmpty().WithMessage("Price is required.")
            .GreaterThan(0).WithMessage("Price must be greater than 0.");

        RuleFor(x => x.CategoryId)
            .NotEmpty().WithMessage("CategoryId is required.")
            .GreaterThan(0).WithMessage("CategoryId must be greater than 0.");
    }
}
