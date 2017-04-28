using System;

namespace HelloWorldClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            HelloWorldServiceClient client = new HelloWorldServiceClient();

            Console.WriteLine(client.GetMessage("Mark"));
        }
    }
}
