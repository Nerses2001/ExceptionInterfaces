using System;

namespace ExceptionInterfaces.Exception
{
    class Car
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool _carIsDead;

        private Radio theMusicBox = new Radio();

        public Car() { }

        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Console.WriteLine("{0} is out of order...", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    _carIsDead = true;
                    CurrentSpeed = 0;
                    //  throw new System.Exception($"{PetName} has overheated!");
                throw new ArgumentOutOfRangeException("acceleration", "Acceleration cannot be negative.");
                }
                else
                {
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }


    }


}
