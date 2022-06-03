using System;

namespace ConsoleApp19
{
    interface Vehicle//interface 
    {
        void changeGear(int a);
        void speedUp(int a);
        void applyBrakes(int a);
    }
    class Bicycle : Vehicle //implementation of interface
    {
        int speed;
        int gear;

        public void applyBrakes(int decrement)//1
        {
            speed = speed - decrement;
        }

        public void changeGear(int newGear)//2
        {
            gear = newGear;//2
        }

        public void speedUp(int increment)//3
        {
            speed = speed + increment;
        }
        public void PrintStates()
        {
            Console.WriteLine("Bicycle Speed : " + speed+"\nBicycle Gear : "+gear);
        }
    }

    class Bike : Vehicle
    {
        int speed;
        int gear;

        public void applyBrakes(int decrement)//3
        {
            speed = speed - decrement;
        }

        public void changeGear(int newGear)//1
        {
            gear = newGear;
        }

        public void speedUp(int increment)//4
        {
            speed = speed + increment;
        }
        public void PrintStates()
        {
            Console.WriteLine("Bike Speed : " + speed + "\nBike Gear : " + gear);
        }
    }
    class Program
    {
        static void Main2(string[] args)
        {
            Bicycle bc = new Bicycle();
            bc.changeGear(2);
            bc.speedUp(3);
            bc.applyBrakes(1);
            bc.PrintStates();


            Bike bk = new Bike();
            bk.changeGear(1);
            bk.speedUp(4);
            bk.applyBrakes(3);
            bk.PrintStates();
        }
    }
}
