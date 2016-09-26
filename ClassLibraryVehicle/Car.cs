using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehicle
{
    public class Car : LandVehicle, Information
    {
        public string Bodytype;
        public string Mode;

        public Car(string n, string v, int c, int mi, string t, string b, string mo)
        {
            this.Name = n;
            this.Vin = v;
            this.Capacity = c;
            this.Miles = mi;
            this.Transmission = t;
            this.Bodytype = b;
            this.Mode = mo;
        }

        public void info()
        {
            Console.WriteLine("The following are car Details:");
            Console.WriteLine("Car Name:" + Name);
            Console.WriteLine("Car Vin:" + Vin);
            Console.WriteLine("Car Capacity:" + Capacity);
            Console.WriteLine("Car Miles:" + Miles);
            Console.WriteLine("Car Transmission:" + Transmission);
            Console.WriteLine("Car Bodytype:" + Bodytype);
            Console.WriteLine("Car Mode:" + Mode);

        }

    }
}
