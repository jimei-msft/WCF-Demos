namespace WcfWebHttpService
{
    public class Service : IService
    {
        public string Echo(string message)
        {
            return "Echo: " + message;
        }

        public string EchoFromBrowser(string message)
        {
            return "Echo: " + message;
        }
    }
}
