using Curs_work_API.Models;

namespace Curs_work_API.Clients
{
    public class Search_Game_Price_Client
    {
		public async Task<List<Wishlist_games>> Search_Game_Price(string game_name)
		{
			if(game_name != null)
			{
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri($"https://best-game-price-search.p.rapidapi.com/bestprice/{game_name}/?page=1&limit=5&currency=USD&maxprice=150"),
					Headers =
					{
						{ "X-RapidAPI-Key", "9c6d310215msh4a0430a9d8cea43p16824djsn22530065288e" },
						{ "X-RapidAPI-Host", "best-game-price-search.p.rapidapi.com" },
					},
				};
				
				var response = await client.SendAsync(request);
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var res = Newtonsoft.Json.JsonConvert.DeserializeObject<Search_Game_Price_Model>(body);


				List<Wishlist_games> res_list = new List<Wishlist_games>(); 
				foreach (var item in res.results)
                {
					Wishlist_games games = new Wishlist_games();
					if(item.title != null)
                    {
						games.Name = item.title;
					}
					if(item.price != 0.0)
                    {
						games.Price = item.price;
					}
					if (item.source != null)
                    {
						games.Store = item.source;
					}
					if(item.url != null)
                    {
						games.URL = item.url;
					}
					res_list.Add(games);

				}
				return res_list;
				
			}
            else
            {
				Wishlist_games games = new Wishlist_games();
				List<Wishlist_games> res_list = new List<Wishlist_games>();
				games.Name = "Wrong Name";
				res_list.Add(games);
				return res_list;
            }

		}
		public async Task<string> Search_Game_Name(string game_name)
		{
			if (game_name != null)
			{
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri($"https://best-game-price-search.p.rapidapi.com/bestprice/{game_name}/?page=1&limit=5&currency=USD&maxprice=150"),
					Headers =
					{
						{ "X-RapidAPI-Key", "9c6d310215msh4a0430a9d8cea43p16824djsn22530065288e" },
						{ "X-RapidAPI-Host", "best-game-price-search.p.rapidapi.com" },
					},
				};
				string result = "";
				var response = await client.SendAsync(request);
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var res = Newtonsoft.Json.JsonConvert.DeserializeObject<Search_Game_Price_Model>(body);
				foreach (var item in res.results)
				{
					result += "Game Name: " + item.title + " | Url: " + item.url +" | " + "\n";
				}
				return result;
			}
			else
			{
				return "Wrong Game Name ";
			}

		}
	}
}
