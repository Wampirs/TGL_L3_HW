using HomeWork_Lecture3.Calculators;

namespace HomeWork_Lecture3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact = FactorialCalculator.CalculateFactorial(Int32.Parse(Console.ReadLine()));
            Console.WriteLine($"Factorial of number is {fact}");
            List<int> fib = FibonacciCalculator.GetFibonacciSequence(Int32.Parse(Console.ReadLine()));
            fib.ForEach(num => Console.Write(num + " "));
        }
    }
}