using System;

namespace RemotingExample.Server
{
    public class RemoteCalculator : MarshalByRefObject, IRemoteCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return (double)a / b;
        }
    }
}
