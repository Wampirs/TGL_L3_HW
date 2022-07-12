

namespace HomeWork_Lecture3.Calculators
{
    public class FactorialCalculator
    {
        public static int CalculateFactorial(int _num)
        {
            return Enumerable.Range(1, _num).Aggregate((x, y) => x * y);
        }
    }
}
