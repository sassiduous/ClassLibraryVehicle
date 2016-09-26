using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehicle
{
    public class Boat : WaterVehicle, Information
    {
        public string Pedaltype;
        public int pedalcount;

        public Boat(string n, string v, int c, int nmi, int lj, string pt, int pc)
        {
            this.Name = n;
            this.Vin = v;
            this.Capacity = c;
            this.Nauticalmiles = nmi;
            this.Lifejackets = lj;
            this.Pedaltype = pt;
            this.pedalcount = pc;
        }
        public void info()
        {
            Console.WriteLine("The following are Boat Details:");
            Console.WriteLine("Boat Name:" + Name);
            Console.WriteLine("Boat Vin:" + Vin);
            Console.WriteLine("Boat Capacity:" + Capacity);
            Console.WriteLine("Boat Nauticalmiles:" + Nauticalmiles);
            Console.WriteLine("Boat Lifejackets:" + Lifejackets);
            Console.WriteLine("Boat Pedaltype:" + Pedaltype);
            Console.WriteLine("Boat pedalcount:" + pedalcount);

        }
    }
}
