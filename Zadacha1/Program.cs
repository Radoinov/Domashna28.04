namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko reda: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Kolko koloni: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrica = new int[rows, cols];

            Console.WriteLine("Vavedete dannite na matricata:");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrica[row, col] = int.Parse(Console.ReadLine());
                }
            }

            
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrica[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
