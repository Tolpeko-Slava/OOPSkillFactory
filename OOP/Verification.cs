using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    static class Verification
    {
        static public bool StrToInt(string str, out int res)
        {
            if(!int.TryParse(str, out res))
            {
                Console.WriteLine("Введите число.");

                return false;
            }

            return true;
        }

        static public bool IntMoreZero(int res)
        {
            if (res <= 0)
            {
                Console.WriteLine("Введите положительное число.");

                return false;
            }

            return true;
        }
    }
}
