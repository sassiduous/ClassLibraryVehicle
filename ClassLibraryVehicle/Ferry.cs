using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehicle
{
    public class Ferry : WaterVehicle, Information
    {
        public string Motor;
        public string Anchor;

        public Ferry(string n, string v, int c, int nmi, int lj, string mo, string a)
        {
            this.Name = n;
            this.Vin = v;
            this.Capacity = c;
            this.Nauticalmiles = nmi;
            this.Lifejackets = lj;
            this.Motor = mo;
            this.Anchor = a;
        }
        public void info()
        {
            Console.WriteLine("The following are Ferry Details:");
            Console.WriteLine("Ferry Name:" + Name);
            Console.WriteLine("Ferry Vin:" + Vin);
            Console.WriteLine("Ferry Capacity:" + Capacity);
            Console.WriteLine("Ferry Nauticalmiles:" + Nauticalmiles);
            Console.WriteLine("Ferry Lifejackets:" + Lifejackets);
            Console.WriteLine("Ferry Motor:" + Motor);
            Console.WriteLine("Ferry Anchor:" + Anchor);

        }
    }
}
