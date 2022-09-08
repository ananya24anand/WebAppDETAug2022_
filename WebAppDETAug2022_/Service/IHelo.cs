namespace WebAppDETAug2022_.Service
{
    public interface IHelo
    {
        string SayHelo(string name);
    }
    public class Helo1 : IHelo
    {
        public string SayHelo(string name)
        {
            return $"Hello {name}, Welcome to ASP. NET Core";
        }
    }
    public class Helo2 : IHelo
    {
        public string SayHelo(string name)
        {
            return $" Hi {name}, how was your day";
        }
    }
}

