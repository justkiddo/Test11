using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_11.Tasks._6
{
    public class SaveReadGeneric <T>
    {
        T[] arr = new T[0];
        public T Save(T t)
        {
            return t;
        }

        public void Read(T t)
        {
        }
    }
}
