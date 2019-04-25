using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVehicle
{

        public class VehicleMain
        {

            public void Test()
            {
                Console.WriteLine("The Test() called");
                //Vehicle.run();

            }


            public static void Main(String[] args)
            {
                // TODO Auto-generated method stub
              //  int v;

                Vehicle v1 = new Car();
                Vehicle v2 = new Car();
                Vehicle v3 = new Car();
                Vehicle v4 = new Car();

                //		VehicleMain.Test();

                v1.run();

                //		v1.doors = 4;
                v1.setDoors(4);
                v2.setDoors(2);
                v1.setColor("Red");
                v2.setColor("White");

                Console.WriteLine("v1.door = " + v1.getDoors());
                Console.WriteLine("v1.color = " + v1.getColor());

                Console.WriteLine("v2.door = " + v2.getDoors());
                Console.WriteLine("v2.color = " + v2.getColor());

            Console.ReadKey();
        }

        }
    }

    
