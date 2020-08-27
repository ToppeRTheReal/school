using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trekant
{
    public class Trekant
    {
        double a, b, c = 0;
        public void Init(double a, double b, double c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new Exception("Ulovlig trekant");
            }
        }
        public double Omkreds()
        {
            return a + b + c;
        }
        public double Areal()
        {
            double s = (a + b + c) / 2;
            double res = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return res;
        }

    }
}