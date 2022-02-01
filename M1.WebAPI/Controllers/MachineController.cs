using M1.Application.Machines.Commans.AddMachine;
using M1.Application.Machines.Commans.DeleteMachine;
using M1.Application.Machines.Queries.GetMachine;
using Microsoft.AspNetCore.Mvc;

namespace M1.WebAPI.Controllers
{
    public class MachineController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await Mediator.Send(new GetMachineQuery(id)));
        }

        [HttpGet]
        public async Task<ActionResult<IList<MachineViewModel>>> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllMachinessQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddMachineCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteMachineCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
