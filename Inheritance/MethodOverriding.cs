namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MethodOverriding
    {
        class Base
        {
            public Base()
            {
                Console.WriteLine("Base");
            }

            public Base(string msg)
            {
                Console.WriteLine(msg);
            }
            public virtual void Method()
            {
                Console.WriteLine("BaseMethod");
            }
            public virtual void Method1()
            {
                Console.WriteLine("BaseMethod 1");
            }
        }

        class Derived : Base
        {
            public Derived(int i) : base("abc")
            {
                Console.WriteLine("Derived" + i);
            }
            public override void Method()
            {
                Console.WriteLine("DerivedMethod");
                base.Method();
            }

            public void Method2()
            {
                Console.WriteLine("DerivedMethod 2");
            }
        }

        public static void Main(string[] args)
        {
            Base A = new Base();
            Base B = new Derived(1);
            // B.Method2();    // Will give a compile time error because reference variable which is of type Base does not have Method2
            Derived C = new Derived(1);
            C.Method2();
            A.Method();
            B.Method();
            C.Method();

            // Derived D = new Base();  // Will give a compile time error as Child class reference variable cannot store base class object
        }
    }
}
