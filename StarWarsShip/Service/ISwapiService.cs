using RestEase;
using StarWarsShip.Models.Response;

namespace StarWarsShip.Service
{
    public interface ISwapiService
    {
        [Get("starships")]
        Task<ShipsListResponse> GetShips();
    }
}
