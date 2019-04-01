using System;

namespace DellChallenge.C
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please refactor the code below whilst taking into consideration the following aspects:
            //      1. clean coding
            //      2. naming standards
            //      3. code reusability, hence maintainability
            StartHere();
            Console.ReadKey();
        }

        private static void StartHere()
        {
            MyObject _MyNewObject = new MyObject();
            int obj1 = _MyNewObject.SumOfTwo(1, 3);
            int num2 = _MyNewObject.SumOfThree(1, 3, 5);
            Console.WriteLine(obj1);
            Console.WriteLine(num2);
        }
    }

    class MyObject : ICalculator
    {

        public int SumOfTwo(int a, int b)
        {
            return a + b;
        }

        public int SumOfThree(int a, int b, int c)
        { 
            return a + b + c;
        }
    }

    public interface ICalculator
    {
        int SumOfTwo(int a, int b);
        int SumOfThree(int a, int b, int c);
    }
}
