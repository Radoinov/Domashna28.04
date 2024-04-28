namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int col = int.Parse(Console.ReadLine());

            
            int[,] matrix = new int[row, col];

            
            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            for (int i = 0; i < row; i++)
            {
                int sum = 0;
                for (int j = 0; j < col; j++)
                {
                    sum += matrix[i, j];
                }
                int average = sum / col;
                matrix[i, col] = average;
            }

            
            Console.WriteLine("The matrix is:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col + 1; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("{0,10}", matrix[row, col]);
        }
    }
}
