using Application.Estadia.UseCases.Commands.CheckIns.CreateCheckIn;
using Application.Estadia.UseCases.Commands.CheckOuts.CreateCheckOut;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Checkin.Controllers.CheckOut
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CheckoutController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateCheckout([FromBody] CreateCheckoutCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}