using StarWarsShip.Models.Response;

namespace StarWarsShip.Facade.Interface
{
    public interface IShipsFacade
    {
        Task<ShipsListResponse> GetShips();
        Task<List<PassengerShipsResponse>> ListShipsStops(int PassengersQuantity);
    }
}
