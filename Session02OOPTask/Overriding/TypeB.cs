using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Overriding
{
    //Video05
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        //override,hide
        //Apply override
        //1.Apply override using 'new' keyword
        //2.Apply override using 'override' keyword==>function in parent shouldn't be private
        // and should be virtual

        //Static binding
        //Complier will bind the function call based on reference not the object
        //It happened at compilation time 
        public new void Fun01()
        {
            Console.WriteLine("Fun01 from type B");
        }

        //Dynamic binding
        //CLR will bind the function call based on object not the reference
        //It happend at runtime
        public override void Fun02()
        {
            Console.WriteLine($"A:{A}, B:{B}");
        }

    }
}