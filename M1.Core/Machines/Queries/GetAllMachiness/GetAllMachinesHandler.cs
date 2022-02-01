using AutoMapper;
using AutoMapper.QueryableExtensions;
using M1.Application.Interfaces.Db;
using M1.Application.Machines.Queries.GetMachine;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace M1.Application.Machines.Queries.GetAllMachiness;

public class GetAllMachinesHandler : IRequestHandler<GetAllMachinessQuery, IList<MachineViewModel>>
{
    private readonly IAppDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetAllMachinesHandler(IMapper mapper, IAppDbContext dbContext)
    {
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<IList<MachineViewModel>> Handle(GetAllMachinessQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Machines
            .ProjectTo<MachineViewModel>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }
}
