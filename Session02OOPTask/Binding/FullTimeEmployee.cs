﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Binding
{
    //Video08
    internal class FullTimeEmployee : Employee
    {

        public double Salary { get; set; }
        public new void Fun01()
        {
            Console.WriteLine("I'm full time  employee:)");
        }
        public override void Fun02()
        {
            Console.WriteLine($"Salary={Salary}");
        }
    }
}
