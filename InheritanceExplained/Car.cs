using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExplained
{
    class Car : Vehicle  // In Java :  class Car extends Vehicle 
    {

        public void run()
        {
            Console.WriteLine("A car is mainly used privaterly...");
            //throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
