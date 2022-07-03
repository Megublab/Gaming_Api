using Curs_work_API.Models;
using Newtonsoft.Json;

namespace Curs_work_API.Clients
{
	public class New_Game_Client
	{

		public async Task<string> Get_New_Game(string platform)
		{
			string[] platforms = {"pc", "ps4", "ps5", "xbox-one", "xbox-series-x", "switch", "android", "ios"};
			platform = platform.Replace(" ", "-").ToLower();
			if (platforms.Contains(platform))
			{
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri($"https://whatoplay.p.rapidapi.com/new?platform={platform}"),
					Headers =
				{
					{ "X-RapidAPI-Key", "9c6d310215msh4a0430a9d8cea43p16824djsn22530065288e" },
					{ "X-RapidAPI-Host", "whatoplay.p.rapidapi.com" },
				},
				};
				var response = await client.SendAsync(request);
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				string result = "";
				var gamejson = Newtonsoft.Json.JsonConvert.DeserializeObject<Abstract_New_Game>(body);
				foreach (var item in gamejson.pc.new_data)
				{
					result += item.game_name + " | " + item.developer + " | " + item.release_date + " | " + "\n";
				}
				return result;
			}
            else
            {
				return "no platform";
            }

			/*
				switch (platform)
				{
					case "android":
						{
							var Androidjson = Newtonsoft.Json.JsonConvert.DeserializeObject<Android>(body);

							foreach (var item in Androidjson.game.data)
							{
								result += item.game_name + "\n";
							}
							break;
						}
					case "ios":
						{
							var IOSjson = Newtonsoft.Json.JsonConvert.DeserializeObject<IOS>(body);

							foreach (var item in IOSjson.game.data)
							{
								result += item.game_name + "\n";
							}
							break;
						}
					case "pc":
						{
							var PCjson = Newtonsoft.Json.JsonConvert.DeserializeObject<New_PC>(body);

							foreach (var item in PCjson.new_game.new_data)
							{
								result += item.game_name + "\n";
							}
							break;
						}
					case "ps3":
						{
							var PS3json = Newtonsoft.Json.JsonConvert.DeserializeObject<PS3>(body);

							foreach (var item in PS3json.game.data)
							{
								result += item.game_name + "\n";
							}
							break;
						}
					case "ps4":
						{
							var PS4json = Newtonsoft.Json.JsonConvert.DeserializeObject<PS4>(body);

							foreach (var item in PS4json.game.data)
							{
								result += item.game_name + "\n";
							}
							break;
						}
					case "ps5":
						{
							var PS5json = Newtonsoft.Json.JsonConvert.DeserializeObject<PS5>(body);

							foreach (var item in PS5json.game.data)
							{
								result += item.game_name + "\n";
							}
							break;
						}
					case "switch":
						{
							var Switchjson = Newtonsoft.Json.JsonConvert.DeserializeObject<Switch>(body);

							foreach (var item in Switchjson.game.data)
							{
								result += item.game_name + "\n";
							}
							break;
						}
					case "xbox-360":
						{
							var Xbox360json = Newtonsoft.Json.JsonConvert.DeserializeObject<Xbox360>(body);

							foreach (var item in Xbox360json.game.data)
							{
								result += item.game_name + "\n";
							}
							break;
						}
					case "xbox-one":
						{
							var XboxOnejson = Newtonsoft.Json.JsonConvert.DeserializeObject<XboxOne>(body);

							foreach (var item in XboxOnejson.game.data)
							{
								result += item.game_name + "\n";
							}
							break;
						}
					case "xbox-series-x":
						{
							var XboxSeriesXjson = Newtonsoft.Json.JsonConvert.DeserializeObject<XboxSeriesX>(body);

							foreach (var item in XboxSeriesXjson.game.data)
							{
								result += item.game_name + "\n";
							}
							break;
						}
					default:
						{
							result = "Platform not found";
							break;
						}
				}
				return result;
			}
			*/
		}
	}
}
