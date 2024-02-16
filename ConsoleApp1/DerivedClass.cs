using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DerivedClass:AClass
    {
        public override void M2()
        {
            base.M2();
            Console.WriteLine("+Method M2 realizing in Aclass");
            
        }    
        public override void M3()
        {
            Console.WriteLine(" Method M3 realizing in Aclass");
        }
        
        public override void M4()
        {
            Console.WriteLine("Method M4 realizing in Aclass");
        }
    }
}
