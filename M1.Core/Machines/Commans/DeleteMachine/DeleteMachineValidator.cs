using FluentValidation;

namespace M1.Application.Machines.Commans.DeleteMachine
{
    public class DeleteMachineValidator : AbstractValidator<DeleteMachineCommand>
    {
        public DeleteMachineValidator()
        {
            RuleFor(model => model.Id)
                .NotEmpty()
                .NotNull();
        }
    }
}
