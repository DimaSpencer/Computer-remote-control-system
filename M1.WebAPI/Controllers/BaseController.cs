using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace M1.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BaseController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => 
            _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        protected Guid UserId => 
            User.Identity.IsAuthenticated ? Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value) : Guid.Empty;
    }
}
