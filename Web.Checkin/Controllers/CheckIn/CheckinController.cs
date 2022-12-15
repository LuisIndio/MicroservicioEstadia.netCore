using Application.Estadia.UseCases.Commands.CheckIns.CreateCheckIn;
using Application.Estadia.UseCases.Commands.CheckIns.DeleteCheckIn;
using Application.Estadia.UseCases.Commands.CheckIns.UpdateCheckIn;
using Application.Estadia.UseCases.Commands.Habitaciones.CreateHabitacion;
using Application.Estadia.UseCases.Commands.Habitaciones.DeleteHabitacion;
using Application.Estadia.UseCases.Queries.CheckIn;
using Application.Estadia.UseCases.Queries.Habitacion;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Checkin.Controllers.CheckIn
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckinController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CheckinController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateCheckin([FromBody] CreateCheckinCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [Route("search")]
        [HttpGet]
        public async Task<IActionResult> SearchCheckin([FromQuery] string? codigo = "")
        {
            var query = new GetListaCheckinQuery
            {
                CheckinSearchTerm = codigo
            };
            var result = await _mediator.Send(query);
            return Ok(result);

        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCheckin([FromBody] DeleteCheckinCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCheckin([FromBody] UpdateCheckinCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
