using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionInterfaces.Exception;
using ExceptionInterfaces.Interfaces;

namespace ExceptionInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Simple Exception Example * ****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            // Car myCar = new Car("Zippy", 20);
            // myCar.CrankTunes(true);
            // for (int i = 0; i < 10; i++)
            //     myCar.Accelerate(10);
            Car myCar = new Car("Rusty", 90);

            try
            {
                myCar.Accelerate(-2000);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("***** Fun with Interfaces *****\n");
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);

            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");

            Octagon oct = new Octagon();
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();
            IDrawToPrinter itfPnner = (IDrawToPrinter)oct;
            itfPnner.Draw();
            IDrawToMemory itfMemory = (IDrawToMemory)oct;
            itfMemory.Draw();

            Console.WriteLine("***** Simple Interface Hierarchy ***★*");
            // Вызвать на уровне объекта.
            Bitmaplmage myBitmap = new Bitmaplmage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpsideDown();
            // Получить IAdvancedDraw явным образом.
            IAdvancedDraw iAdvDraw = myBitmap as IAdvancedDraw;
            if (iAdvDraw != null)
                iAdvDraw.DrawUpsideDown();
            Console.ReadKey();  
        }
    }
}
