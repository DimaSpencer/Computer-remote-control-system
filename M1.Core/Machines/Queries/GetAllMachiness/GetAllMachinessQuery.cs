using M1.Application.Machines.Queries.GetMachine;
using MediatR;

namespace M1.Application.Machines.Queries.GetAllMachiness;

public class GetAllMachinessQuery : IRequest<IList<MachineViewModel>>
{
}