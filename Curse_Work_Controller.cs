using Curs_work_API.Clients;
using Curs_work_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Curs_work_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Curse_Work_Controller : ControllerBase
    {
        private readonly ILogger<Curse_Work_Controller> _logger;
        public Curse_Work_Controller(ILogger<Curse_Work_Controller> logger)
        {
            _logger = logger;
        }
        [HttpGet("Top Best Games")]
        public string Best_Game_For_Platform(string platform)
        {
            Best_Game_Client client = new Best_Game_Client();
            return client.Get_Best_Game(platform).Result;
        }
        [HttpGet("Top New Games")]
        public string New_Game_For_Platform(string platform)
        {
            New_Game_Client client = new New_Game_Client();
            return client.Get_New_Game(platform).Result;
        }
        [HttpGet("Search Game Price")]
        public List<Wishlist_games> Search_Game_Price(string Game_Name)
        {
            Search_Game_Price_Client client = new Search_Game_Price_Client();
            return client.Search_Game_Price(Game_Name).Result;
        }
        [HttpGet("Search Guide Game")]
        public string Get_Video_Guide(string Game_Name)
        {
            Search_Video_Youtube client = new Search_Video_Youtube();
            return client.Get_Video_Guide(Game_Name).Result;
        }
        [HttpGet("Search Content of Game")]
        public string Get_Video_Treiler(string Game_Name)
        {
            Search_Video_Youtube client = new Search_Video_Youtube();
            return client.Get_Video_Guide(Game_Name).Result;
        }
        [HttpGet("Free EpicStore Game")]
        public string GetFreeGames()
        {
            EpicStore_Client client = new EpicStore_Client();
            return client.GetFreeGame().Result;
        }
        [HttpGet("Search Game Name")]
        public string Search_Game_Name(string Game_Name)
        {
            Search_Game_Price_Client client = new Search_Game_Price_Client();
            return client.Search_Game_Name(Game_Name).Result;
        }




    }
}
