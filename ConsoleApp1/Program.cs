using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           DerivedClass d1= new DerivedClass();
            d1.M1();
            d1.M2();
            d1.M3();
            d1.M4();
            Console.ReadKey();
        }
    }
}
