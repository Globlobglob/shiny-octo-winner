using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs
{
    class Dclass1:Cclass1
    {
        public override int Summ(int x ,int y)
        {

            return x + y;
        }

        public override void M1()
        {
            Console.WriteLine("Переопределенный метод");
        }

        public override void Welcome(string hi)
        {
            
            Console.WriteLine(hi);
        }
    }
}
