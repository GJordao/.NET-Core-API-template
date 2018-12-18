using Nancy;

namespace Backend.Api.Modules
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get("/", _ => "Hello World");
            Get("/test", _ => "Tested successfully");
        }
    }
}