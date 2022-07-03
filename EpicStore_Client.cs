using Curs_work_API.Models;

namespace Curs_work_API.Clients
{
    public class EpicStore_Client
    {
		public async Task<string> GetFreeGame()
		{
			HttpClient client = new HttpClient();
			HttpRequestMessage request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://free-epic-games.p.rapidapi.com/free"),
				Headers =
			{
				{ "X-RapidAPI-Key", "9c6d310215msh4a0430a9d8cea43p16824djsn22530065288e" },
			{ "X-RapidAPI-Host", "free-epic-games.p.rapidapi.com" },
			},
			};
			var response = await client.SendAsync(request);
			response.EnsureSuccessStatusCode();
			var body = await response.Content.ReadAsStringAsync();
			var res = Newtonsoft.Json.JsonConvert.DeserializeObject<EpicStore_Model>(body);
			string result = " ";
			result += "Current Games: ";
            foreach (var item in res.freeGames.current)
            {
				result += item.title + " | ";
            }
			result += "\n";
			result += "Upcoming Next Week: ";
            foreach (var item in res.freeGames.upcoming)
            {
				result += item.title + " | ";
            }
			return result;
		}
	}
}
