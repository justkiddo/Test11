using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_11.Classes._5
{
    internal class Derived1 : BaseClass1
    {
        string value4 = "also default";


        public override void ShowValues()
        {
            base.ShowValues();
            Console.Write(value4);
        }
    }
}
