namespace Curs_work_API.Models
{
    public class Youtube_search_guide
    {
        public string country { get; set; }
        public string lang { get; set; }
        public string number_of_videos { get; set; }
        public string query { get; set; }
        public Status status { get; set; }
        public string timezone { get; set; }
        public string token { get; set; }
        public List<Video> videos { get; set; }
    }
    public class Status
    {
        public string message { get; set; }
        public string status { get; set; }
    }

    public class Video
    {
        public string channel_id { get; set; }
        public string description { get; set; }
        public string number_of_views { get; set; }
        public string published_time { get; set; }
        public List<Thumbnail> thumbnails { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string video_id { get; set; }
        public string video_length { get; set; }
    }

    public class Thumbnail
    {
        public int height { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }

}
