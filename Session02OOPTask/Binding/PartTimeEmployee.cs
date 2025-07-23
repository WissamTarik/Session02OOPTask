using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Binding
{
    internal class PartTimeEmployee : Employee
    {

        public double HourRate { get; set; }
        public int NumberOfHours { get; set; }
        public new void Fun01()
        {
            Console.WriteLine("I'm part time  employee:)");
        }
        public override void Fun02()
        {
            Console.WriteLine($"Salary={HourRate * NumberOfHours}");
        }

    }
}
