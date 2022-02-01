using FluentValidation;

namespace M1.Application.Machines.Commans.UpdateMachine
{
    class UpdateMachineValidator : AbstractValidator<UpdateMachineCommand>
    {
        public UpdateMachineValidator()
        {
            RuleFor(model => model.Id)
                .NotEmpty()
                .NotNull()
                .NotEqual(Guid.Empty);
            RuleFor(model => model.Name)
                .NotEmpty()
                .NotNull();
            RuleFor(model => model.Description)
                .NotEmpty()
                .NotNull();
            RuleFor(model => model.IsOnline)
                .NotEmpty()
                .NotNull();
            RuleFor(model => model.HasChromer)
                .NotEmpty()
                .NotNull();
            RuleFor(model => model.HasSteam)
                .NotEmpty()
                .NotNull();
        }
    }
}
