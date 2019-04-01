using System;

namespace DellChallenge.A
{
    class Program
    {
        static void Main(string[] args)
        {
            // State and explain console output order.
            //A.A() is writen by the constructor of base class
            //B.B() is writen by the constructor of the class
            //A .Age is writen by the age setter

            new B();
            Console.ReadKey();
        }
    }

    class A
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                Console.WriteLine("A .Age");
            }
        }


        public A()
        {
            Console.WriteLine("A.A()");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B.B()");
            Age = 0;
        }
    }
}
