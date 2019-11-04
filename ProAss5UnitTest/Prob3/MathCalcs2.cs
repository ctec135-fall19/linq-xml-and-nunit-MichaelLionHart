using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    public class MathCalcs2
    {
        public static byte Add(byte a, byte b)
        {
            checked
            {
                byte x = (byte)(a + b);
                return x;
            }
        }
    }
}
