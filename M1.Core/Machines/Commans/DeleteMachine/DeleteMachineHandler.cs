using M1.Application.Common.Exceptions;
using M1.Application.Interfaces.Db;
using M1.Domain.Entityes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace M1.Application.Machines.Commans.DeleteMachine
{

    public class DeleteMachineHandler : IRequestHandler<DeleteMachineCommand>
    {
        private readonly IAppDbContext _dbContext;

        public DeleteMachineHandler(IAppDbContext context)
        {
            _dbContext = context;
        }

        public async Task<Unit> Handle(DeleteMachineCommand request, CancellationToken cancellationToken)
        {
            Machine machine = await _dbContext.Machines.FirstOrDefaultAsync(m => m.Id == request.Id)
                ?? throw new EntityNotFoundException(nameof(Machine), request.Id);

            _dbContext.Machines.Remove(machine);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
