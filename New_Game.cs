using Newtonsoft.Json;

namespace Curs_work_API.Models
{
    public class Abstract_New_Game
    {
        [JsonProperty("pc")]
        public New_Game pc { get; set; }
        [JsonProperty("ps4")]
        public New_Game ps4 { set { pc = value; } }
        [JsonProperty("ps5")]
        public New_Game ps5 { set { pc = value; } }
        [JsonProperty("xbox-one")]
        public New_Game xboxone { set { pc = value; } }
        [JsonProperty("xbox-series-x")]
        public New_Game xboxseriesx { set { pc = value; } }
        [JsonProperty("switch")]
        public New_Game _switch { set { pc = value; } }
        [JsonProperty("android")]
        public New_Game android { set { pc = value; } }
        [JsonProperty("ios")]
        public New_Game ios { set { pc = value; } }
    }
    public class New_Game
    {
        [JsonProperty("data")]
        public List<Data> new_data { get; set; }
    }
    public class Data
    {
        public int game_id { get; set; }
        public string game_name { get; set; }
        public string platform { get; set; }
        public string release_date { get; set; }
        public string developer { get; set; }
        public string game_themes { get; set; }
        public string box_art { get; set; }
        public string game_url { get; set; }
        public float? total_gamer_count { get; set; }
        public float? total_critic_count { get; set; }
        public float? gamerscore { get; set; }
        public float? criticscore { get; set; }
        public float? playscore { get; set; }
    }
}
