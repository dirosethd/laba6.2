using System;
class Program
{
    static void Main(string[] args)
    {
        int n, m;

        Console.WriteLine("Введите количество строк (n): ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов (m): ");
        m = int.Parse(Console.ReadLine());

        if (n != m)
        {
            Console.WriteLine("Матрица должна быть квадратной (n = m).");
            return;
        }
        int[,] matrix = new int[n, m];
        Console.WriteLine("Введите элементы матрицы (целые числа): ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int product = 1;
        for (int i = 0; i < n; i++)
        {
            product *= matrix[i, i];
        }
        Console.WriteLine($"Произведение элементов главной диагонали матрицы: {product}");
    }
}