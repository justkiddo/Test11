using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_11.Classes
{
    internal class MyString
    {
        string value1 = "devault";
        string value2 = "devault";

        public MyString(string value1, string value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }
        public MyString(string value1)
        {
            this.value1 = value1;
        }
        public MyString()
        {
        }

        public string Reverse(string value)
        {
            char[] chs = value.ToCharArray();
            Array.Reverse(chs);
            return new string(chs);
        }

    }
}
