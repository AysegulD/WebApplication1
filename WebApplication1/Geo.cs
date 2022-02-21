namespace WebApplication1
{
    public class Geo
    {
        public string Lat { get; set; }
        public string Lng { get; set; }
        public Geo(string lat,string lng)
        {
             Lat = lat;
             Lng = lng;
        }
    }
}
