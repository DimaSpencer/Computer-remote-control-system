using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1.Application.Machines.Commans.DeleteMachine
{
    public class DeleteMachineCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
