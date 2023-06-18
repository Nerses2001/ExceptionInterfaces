using System;


namespace ExceptionInterfaces.Interfaces
{
    class Triangle: Shape, IPointy
    {
        public Triangle() { }

        public Triangle(string name):base(name) { }

        public override void Draw()
        {
            {
                Console.WriteLine("Drawing {0} the Triangle", PetName); }        }
        public byte Points { get { return 3; } }



        public byte GetNumberOfPoints()
        {
            return 10;
        }
    }
}
