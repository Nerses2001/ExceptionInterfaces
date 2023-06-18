﻿using System;


namespace ExceptionInterfaces.Interfaces
{
    class Hexagon : Shape, IPointy
    {

        public Hexagon() { }    
        public Hexagon(string name) : base(name) { }    

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
        public byte Points 
        {
            get { return 6; }
        }

        public byte GetNumberOfPoints()
        {
            return 6;
        }
    }
}
