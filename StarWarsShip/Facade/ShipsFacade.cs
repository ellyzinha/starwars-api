using RestEase;
using StarWarsShip.Facade.Interface;
using StarWarsShip.Models.Response;
using StarWarsShip.Service;

namespace StarWarsShip.Facade
{
    public class ShipsFacade : IShipsFacade
    {
        public async Task<ShipsListResponse> GetShips()
        {
            var swapi = RestClient.For<ISwapiService>("https://swapi.dev/api/");
            var response = await swapi.GetShips();

            return response;
        }

        public Task<List<PassengerShipsResponse>> ListShipsStops(int PassengersQuantity)
        {
            List<ShipsResult> ShipsList = GetShips().Result.Results;

            var result = GetStopsInformations(ShipsList, PassengersQuantity);

            return Task.FromResult(result);
        }

        private static List<PassengerShipsResponse> GetStopsInformations(List<ShipsResult> shipsListResponse, int PassengersQuantity)
        {
            List<PassengerShipsResponse> passengerShipsResponses = new();

            foreach (var ships in shipsListResponse)
            {
                var PassengerStringFormatted = FormatPassengerReturn(ships.Passengers);
                if (PassengerStringFormatted != "0")
                {
                    var shipsMaxPassengers = int.Parse(PassengerStringFormatted);
                    var StopsQuantity = PassengersQuantity / shipsMaxPassengers;

                    var passengerShips = new PassengerShipsResponse(); 

                    passengerShips.StarShipName = ships.Name;
                    passengerShips.StarShipsStopsQuantity = StopsQuantity;
                    passengerShips.PassengersQuantity = PassengersQuantity;

                    passengerShipsResponses.Add(passengerShips);
                }
            }

            return passengerShipsResponses;
        }

        private static string FormatPassengerReturn(string passengerReturn)
        {
            var StringFormatted = passengerReturn;

            if (passengerReturn.Contains(","))
            {
                // Remove commas
                var StringComma = passengerReturn.Split(",");
                StringFormatted = StringComma[0];
                
            }
            

            if(passengerReturn == "n/a")
            {
                passengerReturn = "0";
                StringFormatted =  passengerReturn;
            }

            return StringFormatted;

        }

    }
}
