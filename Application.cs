using System;
using static Delegate.AnonymousDelegate;
using static Test.SimpleDelegate;

namespace Delegate
{
    class Application
    {
        static void Main(string[] args)
        {
            // Basic Delegate
            MyDelegate testDelA = new MyDelegate(Func1);
            int a = testDelA(10, 2);
            testDelA = Func2;
            int b = testDelA(1, 2);
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            // Anonymous delegate
            MyDelegateAnonymous testDelB = delegate (string x) { Console.WriteLine(x); return x; };
            testDelB("Hello World 2");

            // Lambda 
            MyDelegateAnonymous testDelC = (string x) => { Console.WriteLine(x); return x; };
            testDelC("Hello World 3");

        }

    }
}
