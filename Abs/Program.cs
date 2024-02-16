using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs
{
    class Program
    {
        static void Main(string[] args)
        {

            Dclass1 d1 = new Dclass1();
            Console.WriteLine( d1.Summ(15, 16));
            d1.M1();
            d1.Welcome("olol");
            Console.ReadKey();
        }
    }
}
