using FluentValidation;

namespace M1.Application.Machines.Commans.AddMachine
{
    public class AddMachineValidator :  AbstractValidator<AddMachineCommand>
    {
        public AddMachineValidator()
        {
            RuleFor(model => model.Name)
                .NotEmpty()
                .MaximumLength(50)
                .MinimumLength(1);
        }
    }
}
