using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

        public double tinhTienDien(int socu, int somoi)
        {
            const double BAC1 = 1484, BAC2 = 1533, BAC3 = 1786, BAC4 = 2242, BAC5 = 2503, BAC6 = 2587;

            double tien = 0;
            int tieuthu = somoi - socu;

            if (tieuthu <= 50) tien = tieuthu * BAC1;
            else if (tieuthu > 50 && tieuthu <= 100) tien = 50 * BAC1 + (tieuthu - 50) * BAC2;
            else if (tieuthu > 100 && tieuthu <= 200) tien = 50 * BAC1 + 50 * BAC2 + (tieuthu - 100) * BAC3;
            else if (tieuthu > 200 && tieuthu <= 300) tien = 50 * BAC1 + 50 * BAC2 + 100 * BAC3 + (tieuthu - 200) * BAC4;
            else if (tieuthu > 300 && tieuthu <= 400) tien = 50 * BAC1 + 50 * BAC2 + 100 * BAC3 + 100 * BAC4 + (tieuthu - 300) * BAC5;
            else tien = 50 * BAC1 + 50 * BAC2 + 100 * BAC3 + 100 * BAC4 + 100 * BAC5 + (tieuthu - 400) * BAC6;

            tien = tien * 1.1;
            return tien;
        }

    }
}
