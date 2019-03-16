using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {

      public DerivedClass()//Constructor
        {
            Console.WriteLine("Constructor");
            publicfield = "DerivedClass public_field";
            protectedfield = "DerivedClass protected_field";
          
        }

        public void Callfield()
        {
            Console.WriteLine(protectedfield);
        }
    }
}
