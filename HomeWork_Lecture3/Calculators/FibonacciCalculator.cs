namespace HomeWork_Lecture3.Calculators
{
    public class FibonacciCalculator
    {
        public static List<int> GetFibonacciSequence (int _num)
        {
            List<int> fibonacciSequence = new List<int> ();

            Enumerable.Range(0, _num)
                .ToList()
                .ForEach(num =>
                    fibonacciSequence.Add(num <= 1 ? 1 :
                        fibonacciSequence[num - 2] + fibonacciSequence[num - 1]));

            return fibonacciSequence.AsEnumerable().Where(x=>x<=_num).Select(x=>x).ToList(); //Not the best solution, but used for more practice in LINQ
        }
    }
}
