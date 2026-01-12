namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();
            List<double> numbers = input.Split(' ').Select(double.Parse).ToList();

            double mean = numbers.Average();
            double median = CalculateMedian(numbers);
            double mode = CalculateMode(numbers);

            Console.WriteLine($"Sredno aritmetichno: {mean}");
            Console.WriteLine($"Median: {median}");
            Console.WriteLine($"Mode: {mode}");
        }

        static double CalculateMedian(List<double> numbers)
        {
            numbers.Sort();
            int count = numbers.Count;
            if (count % 2 == 0)
            {
                return (numbers[count / 2 - 1] + numbers[count / 2]) / 2;
            }
            else
            {
                return numbers[count / 2];
            }
        }

        static double CalculateMode(List<double> numbers)
        {
            return numbers.GroupBy(n => n)
                          .OrderByDescending(g => g.Count())
                          .First().Key;
        }
    }
}
