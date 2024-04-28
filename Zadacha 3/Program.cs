namespace Zadacha_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko reda: ");

            int rows = int.Parse(Console.ReadLine());
            Console.Write("kolko koloni: ");
            int cols = int.Parse(Console.ReadLine());

            
            int[,] matrix = new int[rows, cols];

            
            Console.WriteLine("Vavedete elementite na matricata:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            
            
            for (int j = 0; j < cols; j++)
            {
                int min = matrix[0, j];
                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                Console.Write($"{min} ");
            }
        }

    }
}

