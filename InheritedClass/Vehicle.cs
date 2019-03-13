using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedClass
{
     class Vehicle
    {

        static int vehicleCount = 0;

        private int doors;
        private int speed;
        private String color;

         public  void run()
        {
            Console.WriteLine("Vehicle::run() called");

        }
        

        public Vehicle()
        {
            //		Console.WriteLine("A vehicle object is created");
            vehicleCount++;
            Console.WriteLine("Vehicle(s) created: " + vehicleCount);

        }

        public int getDoors()
        {  // Getter -> ret
            return doors;
        }

        public void setDoors(int doors)
        {
            this.doors = doors;
        }

        public int getSpeed()
        {
            return speed;
        }

        public void setSpeed(int speed)
        {
            this.speed = speed;
        }

        public String getColor()
        {
            return color;
        }

        public void setColor(String color)
        {
            this.color = color;
        }


    }
}
