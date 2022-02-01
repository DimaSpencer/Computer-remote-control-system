using AutoMapper;
using MediatR;

namespace M1.Application.Machines.Queries.GetMachine;

public class GetMachineQuery : IRequest<MachineViewModel>
{
    public GetMachineQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}