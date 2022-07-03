using Newtonsoft.Json;
namespace Curs_work_API.Models
{
    public class Abstract_Best_Game
    {
        [JsonProperty("pc")]
        public Best_Game pc { get; set; }
        [JsonProperty("ps3")]
        public Best_Game ps3 { set { pc = value; } }
        [JsonProperty("ps4")]
        public Best_Game ps4 { set { pc = value; } }
        [JsonProperty("ps5")]
        public Best_Game ps5 { set { pc = value; } }
        [JsonProperty("xbox-360")]
        public Best_Game xbox360 { set { pc = value; } }
        [JsonProperty("xbox-one")]
        public Best_Game xboxone { set { pc = value; } }
        [JsonProperty("xbox-series-x")]
        public Best_Game xboxseriesx { set { pc = value; } }
        [JsonProperty("3ds")]
        public Best_Game threeds { set { pc = value; } }
        [JsonProperty("wii-u")]
        public Best_Game wiiu { set { pc = value; } }
        [JsonProperty("switch")]
        public Best_Game _switch { set { pc = value; } }
        [JsonProperty("android")]
        public Best_Game android { set { pc = value; } }
        [JsonProperty("ios")]
        public Best_Game ios { set { pc = value; } }
        [JsonProperty("vita")]
        public Best_Game vita { set { pc = value; } }
    }

    public class Best_Game
    {
        public List<Datum> data { get; set; }
    }
    public class Datum
    {
        public int game_id { get; set; }
        public string game_name { get; set; }
        public string platform { get; set; }
        public string release_date { get; set; }
        public string developer { get; set; }
        public string game_themes { get; set; }
        public string box_art { get; set; }
        public string game_url { get; set; }
        public int total_gamer_count { get; set; }
        public int total_critic_count { get; set; }
        public float gamerscore { get; set; }
        public float criticscore { get; set; }
        public float playscore { get; set; }
      
    }
    
}
