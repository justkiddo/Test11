using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_11.Classes._5
{
    internal class BaseClass1
    {
         string value1 = "default";
         string value2 = "default";

        public virtual void ShowValues()
        {
            Console.WriteLine(value1);
            Console.WriteLine(value2);
        }

    }
}
