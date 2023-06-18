using System;

namespace ExceptionInterfaces.Interfaces
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        //public void Draw()
        //{
        //    Console.WriteLine("Drawing the Octagon...");
        //}
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to from ...");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to mamory ...");
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to a printer ...");
        }
    }
}
