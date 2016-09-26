using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehicle
{
    public class Truck : LandVehicle, Information
    {
        public string Trailertype;
        public string Trailersize;

        public Truck(string n, string v, int c, int mi, string t, string tt, string ts)
        {
            this.Name = n;
            this.Vin = v;
            this.Capacity = c;
            this.Miles = mi;
            this.Transmission = t;
            this.Trailertype = tt;
            this.Trailersize = ts;
        }
        public void info()
        {
            Console.WriteLine("The following are Truck Details:");
            Console.WriteLine("Truck Name:" + Name);
            Console.WriteLine("Truck Vin:" + Vin);
            Console.WriteLine("TRuck Capacity:" + Capacity);
            Console.WriteLine("Truck Miles:" + Miles);
            Console.WriteLine("Truck Transmission:" + Transmission);
            Console.WriteLine("Truck Bodytype:" + Trailertype);
            Console.WriteLine("Truck Mode:" + Trailersize);

        }
    }
}
