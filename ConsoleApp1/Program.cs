using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public int Method(int a, double b)
        {
            return a + 1;
        }

        public int Method(int a, int b)
        {
            return a + b;
        }

        class sample
        {

        }

        static void Main()
        {
            Program p = new Program();
            p.Method(5, 4.1);
            p.Method(1, 2);
            sample s = new sample();
        }

        Func<int, int> program = num => num + 5;
    }

    class Test<T>
    {
        
    }
}
