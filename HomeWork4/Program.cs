using System;
using HW4Lib;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HW4Tasks.PowerXToExp(1, 3));            
            HW4Tasks.PrintArray(HW4Tasks.NumbersMultipliedN(13));
            HW4Tasks.SquaresToN(13);
            Console.WriteLine(HW4Tasks.MaxDivider(101));
            Console.WriteLine(HW4Tasks.Task5(1, 14));
            Console.WriteLine(HW4Tasks.Fibonacci_recursion(5));
            Console.WriteLine(HW4Tasks.Fibonacci(5));
            Console.WriteLine(HW4Tasks.GcdEuclidean_recursion(50, 120));
            Console.WriteLine(HW4Tasks.GcdEuclidean(50, 120));
            Console.WriteLine(HW4Tasks.OddDigitsCount(123123));
            Console.WriteLine(HW4Tasks.NumberReverse(12345600));
            HW4Tasks.NumbersEvenDigitsSum(1000);
            Console.WriteLine(HW4Tasks.Task12(123, 456));
            Console.WriteLine(HW4Tasks.Bisection(36*6));
            Console.WriteLine("Hello World!");
        }
    }
}
