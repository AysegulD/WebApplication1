namespace WebApplication1
{
    public class Company
    {
        public string Name { get; set; }
        public string  CatchPhrase { get; set; }
        public string BS { get; set; }
        public Company(string name,string catchphrase,string bs)
        {
            Name = name;
            CatchPhrase = catchphrase;
            BS = bs;
        }
    }
}
