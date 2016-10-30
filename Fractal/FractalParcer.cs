using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    class FractalParcer
    {
        public static String FullRule(string Aksiom, string Rule1, string Rule2, int N)
        {
            StringBuilder bulder = new StringBuilder(Aksiom);

            for (int i = 0; i < N; i++)
            {
                bulder.Replace("F", Rule1);
                bulder.Replace("X", Rule2);
            }
            return bulder.ToString();
        }
    }
}
