using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Access_Modifers_Library
{
    internal class Child01 : ParentTask
    {
        public Child01()
        {
            ParentTask parent = new ParentTask();
            //parent.Func02();//Valid
            //parent.Func01();//Invalid
            //parent.Func03();//Invalid
            parent = new Child01();
            //parent.Func02();//Valid;
            //parent.Func01();//Invalid
            //parent.Func03();//Invalid
        }
        public void Test()
        {
            Func01();//Valid because its protected function 
            Func02();//Valid because its internal protected 
            Func03();//Valid beacause its private protected
        }
    }
}
