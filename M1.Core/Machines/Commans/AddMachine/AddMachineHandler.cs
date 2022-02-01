using M1.Application.Interfaces.Db;
using M1.Domain.Entityes;
using MediatR;

namespace M1.Application.Machines.Commans.AddMachine
{

    public class AddMachineHandler : IRequestHandler<AddMachineCommand>
    {
        private readonly IAppDbContext _dbContext;

        public AddMachineHandler(IAppDbContext context)
        {
            _dbContext = context;
        }

        public async Task<Unit> Handle(AddMachineCommand request, CancellationToken cancellationToken)
        {
            Machine machine = new()
            {
                Name = request.Name,
                HasChrome = request.HasChrome,
                HasSteam = request.HasSteam,
                IsOnline = true,
                Description = request.Description,
                System = request.System,
                CPU = request.CPU
            };

            await _dbContext.Machines.AddAsync(machine, cancellationToken);
            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
