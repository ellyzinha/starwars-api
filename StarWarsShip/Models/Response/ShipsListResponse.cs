using Newtonsoft.Json;

namespace StarWarsShip.Models.Response
{
    public class ShipsListResponse
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<ShipsResult> Results { get; set; }
    }
}
