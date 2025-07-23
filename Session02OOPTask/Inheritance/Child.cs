using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }
        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;

        }

        //Override or hide
        public void Fun01()
        {
            Console.WriteLine("I'm child or subclass or derived class");
        }
        public void Fun02()
        {
            Console.WriteLine($"X={X},Y={Y},Z={Z}");
        }
        public override string ToString()
        {
            return $"X:{X},Y:{Y},Z:{Z}";
        }
    }
}