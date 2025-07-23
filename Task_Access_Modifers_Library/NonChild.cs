using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Access_Modifers_Library
{
    internal class NonChild
    {
        public void Test()
        {
            ParentTask parent = new ParentTask();
            parent.Func02();//Valid beca
            //parent.Func01();//Invalid
            //parent.Func03();//Invalid
            Child01 child01 = new Child01();
            child01.Func02();//Valid because its protected internal
            //child01.Func03();//Invalid because it is private protected
        }
    }
}
