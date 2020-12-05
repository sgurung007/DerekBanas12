using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanas12
{
    class surajGenericMethod
    {
        public static void GetSum<T>(ref T num1,
            ref T num2)
        {
            double dblx = Convert.ToDouble(num1);
            double dbly = Convert.ToDouble(num2);
            Console.WriteLine($"{dblx} + {dbly} = {dblx + dbly}");
        }
    }
}
