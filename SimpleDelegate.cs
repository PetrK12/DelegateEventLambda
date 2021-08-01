using System;

namespace Test
{
    class SimpleDelegate
    {
        public delegate void MyDelegateAnnonymous(string d);
        public delegate int MyDelegate (int arg, int arg2);
        public static int Func1(int a, int b)
        {
            return Func3(a, b);
        }
        public static int Func2(int a, int b)
        {
            return a * b;
        }
        private static int Func3(int a, int b)
        {
            int result = a + b == 0 ? 1 : 0;
            return result;
        }
    }
}
