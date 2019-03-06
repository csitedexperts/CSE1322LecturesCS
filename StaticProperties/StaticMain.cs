using System;

namespace StaticProperties
{
    class Car
    {
        public int id;
        public static String model;
        public void setId() {

        }
        public static void setModel()  {

        }

    }

    class StaticMain {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Car.id = F9C1010;
            c1.id = 1010;

            model = "Ford";

            Car.model = "Ford";
            c1.model = "Ford";

            Car.setId();
            setId();
            setModel();

            c1.setModel();
            Car.setModel();


        }
    }
}
