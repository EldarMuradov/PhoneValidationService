using System;
using Test.App.Service;

namespace Test
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type 'exit' to leave.");

            SingleServerAdapter<IValidator> server = new(new Validator());
            server.Init();
            while (server.IsRun)
                server.Receive(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
