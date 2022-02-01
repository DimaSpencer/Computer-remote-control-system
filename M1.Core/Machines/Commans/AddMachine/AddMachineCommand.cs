using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1.Application.Machines.Commans.AddMachine
{
    public class AddMachineCommand : IRequest
    {
        public string System { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public bool HasSteam { get; set; }
        public bool HasChrome { get; set; }

        public string CPU { get; set; }
    }
}
