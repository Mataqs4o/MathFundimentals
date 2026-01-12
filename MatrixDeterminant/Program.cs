namespace MatrixDeterminant
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter the elements of a 3x3 matrix:");
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < 3; j++)
                    matrix[i, j] = int.Parse(input[j]);
            }
            int determinant = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                              matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                              matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
            Console.WriteLine($"Determinant: {determinant}");
        }
    }
}
