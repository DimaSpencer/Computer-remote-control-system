using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1.Application.Machines.Commans.UpdateMachine
{
    public class UpdateMachineCommand : IRequest
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsOnline { get; set; }
        
        public bool HasSteam { get; set; }
        public bool HasChromer { get; set; }
    }
}
