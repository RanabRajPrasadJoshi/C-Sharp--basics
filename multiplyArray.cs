using System;

class MatrixMultiplication
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows and columns for the first matrix:");
        int rows1 = int.Parse(Console.ReadLine());
        int cols1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of rows and columns for the second matrix:");
        int rows2 = int.Parse(Console.ReadLine());
        int cols2 = int.Parse(Console.ReadLine());

        if (cols1 != rows2)
        {
            Console.WriteLine("Matrix multiplication not possible. Columns of the first matrix must equal rows of the second matrix.");
            return;
        }

        int[,] matrix1 = new int[rows1, cols1];
        int[,] matrix2 = new int[rows2, cols2];
        int[,] result = new int[rows1, cols2];

        Console.WriteLine("Enter elements of the first matrix:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                Console.Write($"Matrix1[{i},{j}]: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements of the second matrix:");
        for (int i = 0; i < rows2; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write($"Matrix2[{i},{j}]: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

       
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        Console.WriteLine("Resultant Matrix:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
