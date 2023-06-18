using System;


namespace ExceptionInterfaces.Interfaces
{
    internal class Bitmaplmage:IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawing...");

        }
        public void DrawInBoundingBox(int top, int left, int bottom, int right)
        {
            Console.WriteLine("Drawing in a box...");
        }

        public void DrawUpsideDown()
        {
            Console.WriteLine("Drawing upside down!");
        }

        }
}
