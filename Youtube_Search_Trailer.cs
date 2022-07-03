using Curs_work_API.Models;

namespace Curs_work_API.Clients
{
    public class Youtube_Search_Trailer
    {
		public async Task<string> Get_Video_Treiler(string search_game)
		{
			try
			{
				search_game = search_game.ToLower();
				if(search_game.Contains(" "))
                {
					search_game = search_game.Replace(" ", "+");
                }
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri($"https://youtube-search6.p.rapidapi.com/search/?query={search_game}&number=5&lang=en"),
					Headers =
				{
					{ "X-RapidAPI-Key", "9c6d310215msh4a0430a9d8cea43p16824djsn22530065288e" },
					{ "X-RapidAPI-Host", "youtube-search6.p.rapidapi.com" },
				},
				};
				var response = await client.SendAsync(request);
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var res = Newtonsoft.Json.JsonConvert.DeserializeObject<Youtube_search_guide>(body);
				string result = " ";
				foreach (var item in res.videos)
				{
					result += "https://www.youtube.com/watch?v=" + item.video_id + " | " + "\n";
				}
				return result;
			}
			catch (SystemException)
			{
				return "Somesing wrong 0~0";
			}


		}
	}
}
