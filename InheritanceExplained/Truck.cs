using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExplained
{
    class Truck: Vehicle
     {
        public void run()
        {
            Console.WriteLine("A Truck is mainly used for transporting goods...");
            //throw new NotImplementedException();
        }

    }
}
