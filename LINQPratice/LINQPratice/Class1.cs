using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPratice
{
    class Class1
    {
        public static void main(string[] argv)
        {
            Func<int, double> square = x => x * x;
            Console.WriteLine(square(5));
        }
    }
}
