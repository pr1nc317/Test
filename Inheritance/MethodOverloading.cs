namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MethodOverloading
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

        //static void Main()
        //{
        //    MethodOverloading p = new MethodOverloading();
        //    p.Method(5, 4.1);
        //    p.Method(1, 2);
        //    sample s = new sample();
        //}

        Func<int, int> program = num => num + 5;

        class Test<T>
        {

        }
    }
}
