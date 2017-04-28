using System;

namespace HelloWorldService
{
    public class HelloWorldService : IHelloWorldService
    {
        public String GetMessage(string name)
        {
            return $"Hello world from {name}!";
        }
    }
}
