using MathNet.Numerics;
using System.Linq;
namespace Coefficents_of_polinom

{


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coefficients separated by space:");
            var coefficients = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var polynomial = new Polynomial(coefficients);
            var roots = polynomial.Roots();
            Console.WriteLine("Roots: " + string.Join(", ", roots));
        }
    }
}
