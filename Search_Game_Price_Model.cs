namespace Curs_work_API.Models
{
    public class Search_Game_Price_Model
    {
        public Pageinfo pageInfo { get; set; }
        public List<Result> results { get; set; }
    }
    public class Pageinfo
    {
        public int totalResults { get; set; }
        public int limit { get; set; }
    }

    public class Result
    {
        public string errorText { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public float price { get; set; }
        public string currency { get; set; }
        public string currency_tag { get; set; }
        public string old_price { get; set; }
        public string discount { get; set; }
        public string release_date { get; set; }
        public string img { get; set; }
        public string url { get; set; }
        public string source { get; set; }
    }
}
