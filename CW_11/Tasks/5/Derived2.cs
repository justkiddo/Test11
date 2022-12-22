using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_11.Classes._5
{
    internal class Derived2: BaseClass1
    {
        string value3 = "olso default";


        public override void ShowValues()
        {
            base.ShowValues();
            Console.Write(value3);
        }


    }
}
