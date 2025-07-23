using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Access_Modifers_Library;

namespace TaskAccess_Modifiers
{
    internal class Child02 : ParentTask
    {
        public void Test()
        {
            Func01();
            Func02();
            //Func03();//Invalid
            ParentTask parent = new ParentTask();

        }
    }
}
