using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{
    public class ErrorsController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error()
        {
            Exception exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
            return Problem(); //use to return error details in the request
        }
    }
}
