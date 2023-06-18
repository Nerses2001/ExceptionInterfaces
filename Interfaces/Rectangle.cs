using System;

namespace ExceptionInterfaces.Interfaces
{
    internal class Rectangle : IShape
    {
        public int GetNumberOfSides()
        {
            return 4;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing ...");
        }
        public void Print()
        {
            Console.WriteLine("Printing ...");
        }
    }
}
