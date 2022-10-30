using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtClassLibrary
{
    public static class Calculator
    {
        public static T Add<T>(this T num1, T num2)
        {
            dynamic x = num1;
            dynamic y = num2;

            return x + y;
        }
    }
}
