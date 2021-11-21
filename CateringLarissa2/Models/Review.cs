namespace CateringLarissa2.Models
{
    public class Review
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string user { get; set; }
        public int rating { get; set; }

        public Review()
        {

        }
    }
}
