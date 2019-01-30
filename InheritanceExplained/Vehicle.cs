using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExplained
{
     class Vehicle : Object   // For Java class Vehicle extends Object 
    {

        static int vehicleCount = 0;

        private int doors;
        private int speed;
        private String color;

        public static void run()
        {
            Console.WriteLine("The run() called..");
        }

        public Vehicle()
        {
            //		System.out.println("A vehicle object is created");
            vehicleCount++;
            Console.WriteLine("Vehicle(s) created: " + vehicleCount);

        }

        public Vehicle(int doors, int speed, String color)
        {
            this.doors = doors; this.speed = speed; this.color = color;

        }

        public override string ToString()
        {
           return base.ToString();

        //    return Console.WriteLine("The fields are" + this.doors + "  " + this.speed + "  " + this.color);
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
