using System;

namespace ExceptionInterfaces.Interfaces
{
    internal class Square : IShape
    {
        void IDrawable.Draw()
        {
            Console.WriteLine("Drawing *** ...");
        }

        void IPrintable.Draw()
        {
            Console.WriteLine("Drawing  Square ...");
        }

        int IShape.GetNumberOfSides()
        {
            return 8;
        }

        void IPrintable.Print()
        {
            Console.WriteLine("Printing Square ...");
        }
    }
}
