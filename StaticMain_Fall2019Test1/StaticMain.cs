using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMain_Fall2019Test1
{
    class StaticMain
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();

            Car.setModel();     // A
            //		Car.id = 91010;
            //		setModel();
            //		c1.id = 81010;
            //		Car.setID();
            c1.setID();         // F
            //		setID();
            c1.color = "red";  // H
            //		color = "green";
            Car.model = "Ford";  // J
            c1.make = "mustang";  // K
        }
    }
}
