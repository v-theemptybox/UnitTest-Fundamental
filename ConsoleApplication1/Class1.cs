using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Class1
    {
        public int MaxAndMean(int a, int b, int c, out double mean)
        {
            mean = (a + b + c) / 3.0;
            int maximum = 0;
            if (a > b)
            {
                if (a > c)
                    maximum = a;
                else
                    maximum = b;
            }
            else if (b > c)
                maximum = b;
            else
                maximum = c;
            return maximum;
        }
    }
}
