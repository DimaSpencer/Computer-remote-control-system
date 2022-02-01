using FluentValidation;

namespace M1.Application.Machines.Queries.GetMachine;

public class GetMachineValidator : AbstractValidator<GetMachineQuery>
{
    public GetMachineValidator()
    {
        RuleFor(model => model.Id)
            .NotEqual(Guid.Empty)
            .NotNull()
            .NotEmpty();
    }
}
