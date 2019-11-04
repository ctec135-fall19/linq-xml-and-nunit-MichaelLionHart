using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("96 + 99 = {0}", MathCalcs.Add((byte)(96), (byte)(99)));
            Console.WriteLine("96 + 201 = {0}", MathCalcs.Add(96, 201));
        }
    }
}
