using RemotingExample.Server;
using System;
using System.Runtime.Remoting;

namespace RemotingExample.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IRemoteCalculator remoteCalculator = (IRemoteCalculator)Activator.GetObject(
            typeof(IRemoteCalculator), "tcp://localhost:1234/RemoteCalculator");

            Console.WriteLine("Enter two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = remoteCalculator.Add(a, b);
            int difference = remoteCalculator.Subtract(a, b);
            int product = remoteCalculator.Multiply(a, b);
            double quotient = remoteCalculator.Divide(a, b);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");

            Console.ReadLine();
        }
    }
}

