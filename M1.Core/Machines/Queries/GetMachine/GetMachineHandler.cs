using AutoMapper;
using M1.Application.Common.Exceptions;
using M1.Application.Interfaces.Db;
using M1.Domain.Entityes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace M1.Application.Machines.Queries.GetMachine;
public class GetMachineHandler : IRequestHandler<GetMachineQuery, MachineViewModel>
{
    private readonly IAppDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetMachineHandler(IMapper mapper, IAppDbContext dbContext)
    {
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<MachineViewModel> Handle(GetMachineQuery request, CancellationToken cancellationToken)
    {
        Machine machine = await _dbContext.Machines.FirstOrDefaultAsync(m => m.Id == request.Id, cancellationToken)
            ?? throw new EntityNotFoundException(nameof(Machine), request.Id);

        return _mapper.Map<MachineViewModel>(machine);
    }
}