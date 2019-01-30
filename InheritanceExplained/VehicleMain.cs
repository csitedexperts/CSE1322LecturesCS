using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExplained
{

        public class VehicleMain
        {

            public void Test()
            {
                Console.WriteLine("The Test() called");
                Vehicle.run();

            }


            public static void Main(String[] args)
            {
                // TODO Auto-generated method stub
                int v;

                Vehicle v1 = new Vehicle();
                Vehicle v2 = new Vehicle();
                Vehicle v3 = new Vehicle();
                Vehicle v4 = new Vehicle();

            Vehicle v5 = new Vehicle(4, 160, "White");
            Vehicle v6 = new Vehicle(2, 120, "Red");

            Console.WriteLine("v5= " + v1);
            Console.WriteLine("v6= " + v1);


            //		v1.doors = 4;

            Console.WriteLine("v1.door = " + v1.getDoors());
            Console.WriteLine("v1.color = " + v1.getColor());

            Console.WriteLine("v2.door = " + v2.getDoors());
            Console.WriteLine("v2.color = " + v2.getColor());

            Console.ReadKey();


            /*
                        Bus b1 = new Bus();
                        b1.run();
                        b1.setDoors(6);
                        Console.WriteLine("b1.door = " + b1.getDoors());


                        Car c1 = new Car();
                        c1.setDoors(4);
                        c1.setColor("Red");


                        Car c2 = new Car();
                        c2.setDoors(2);
                        c2.setColor("White");


                        Console.WriteLine("c1.door = " + c1.getDoors());
                        Console.WriteLine("c1.color = " + c1.getColor());

                        Console.WriteLine("c2.door = " + c2.getDoors());
                        Console.WriteLine("c2.color = " + c2.getColor());


                        Truck t1 = new Truck();
                        Truck t2 = new Truck();
                        t1.setDoors(2);
                        t1.setColor("Gray");
                        t2.setDoors(2);
                        t2.setColor("Black");


                        Console.WriteLine("t1.door = " + t1.getDoors());
                        Console.WriteLine("t1.color = " + t1.getColor());

                        Console.WriteLine("t2.door = " + t2.getDoors());
                        Console.WriteLine("t2.color = " + t2.getColor());

                        c1.run();
                        c2.run();

                        t1.run();
                        t2.run();


                        //		VehicleMain.Test();

                */

        }


    }
    }

    
