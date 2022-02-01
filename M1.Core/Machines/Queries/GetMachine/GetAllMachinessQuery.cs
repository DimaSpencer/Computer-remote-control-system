using MediatR;

namespace M1.Application.Machines.Queries.GetMachine;

public class GetAllMachinessQuery : IRequest<IList<MachineViewModel>>
{
}
