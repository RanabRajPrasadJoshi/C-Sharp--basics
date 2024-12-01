using System;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the number of rows:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns:");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[rows, columns];
        int[,] matrix2 = new int[rows, columns];
        int[,] resultMatrix = new int[rows, columns];

        
        Console.WriteLine("Enter the elements of the first matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        
        Console.WriteLine("Enter the elements of the second matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("Matrix after addition:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
