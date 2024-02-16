using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class AClass
    {/// <summary>
    /// usual method in absract class
    /// </summary>
        public void M1()
        {
            Console.WriteLine("Usual method M1 in aclass");
        }
        /// <summary>
        /// usual virtual method in abstract class
        /// </summary>
        public virtual void M2()
        {
            Console.WriteLine("Virtual method M2 in aclass");
        }
        /// <summary>
        /// Two abstract method M3 & M4 in abstract class
        ///
        /// </summary>
      public abstract void M3();
       public abstract void M4();
       
    }
}
