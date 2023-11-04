using Microsoft.AspNetCore.Mvc;
using StarWarsShip.Facade.Interface;
using StarWarsShip.Models.Request;

namespace StarWarsShip.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipsController : ControllerBase
    {

        private readonly ILogger<ShipsController> _logger;
        private readonly IShipsFacade _shipsFacade;

        public ShipsController(ILogger<ShipsController> logger, IShipsFacade shipsFacade)
        {
            _logger = logger;
            _shipsFacade = shipsFacade;
        }

        [HttpGet]
        public async Task<IActionResult> GetShipsAsync()
        {
            var response = await _shipsFacade.GetShips().ConfigureAwait(false);
            return Ok(response);
        }

        [HttpGet("/ListStops")]
        public async Task<IActionResult> GetShipsStops([FromQuery] int shipsRequest)
        {
            var response = await _shipsFacade.ListShipsStops(shipsRequest);
            return Ok(response);
        }
    }
}