using Application.Estadia.UseCases.Commands.CheckIns.UpdateCheckIn;
using Application.Estadia.UseCases.Commands.Habitaciones.CreateHabitacion;
using Application.Estadia.UseCases.Commands.Habitaciones.DeleteHabitacion;
using Application.Estadia.UseCases.Commands.Habitaciones.UpdateHabitacion;
using Application.Estadia.UseCases.Queries.Habitacion;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Checkin.Controllers.Habitacion
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabitacionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HabitacionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("search")]
        [HttpGet]
        public async Task<IActionResult> SearchHabitacion([FromQuery] string? codigo = "")
        {
            var query = new GetListaHabitacionesQuery
            {
                CodigoSearchTerm = codigo
            };
            var result = await _mediator.Send(query);
            return Ok(result);

        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateHabitacion([FromBody] CreateHabitacionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteHabitacion([FromBody] DeleteHabitacionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateHabitacion([FromBody] UpdateHabitacionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
