using M1.Application.Common.Exceptions;
using M1.Application.Interfaces.Db;
using M1.Domain.Entityes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace M1.Application.Machines.Commans.UpdateMachine
{
    public class UpdateMachineHanlder : IRequestHandler<UpdateMachineCommand>
    {
        private readonly IAppDbContext _dbContext;

        public UpdateMachineHanlder(IAppDbContext context)
        {
            _dbContext = context;
        }

        public async Task<Unit> Handle(UpdateMachineCommand request, CancellationToken cancellationToken)
        {
            Machine machine = await _dbContext.Machines.FirstOrDefaultAsync(m => m.Id == request.Id, cancellationToken) 
                ?? throw new EntityNotFoundException(nameof(Machine), request.Id);

            machine.Name = request.Name;
            machine.Description = request.Description;
            machine.IsOnline = request.IsOnline;
            machine.HasChrome = request.HasChromer;
            machine.HasSteam = request.HasSteam;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
