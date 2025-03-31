namespace Task5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[m, n];
            FillMatrixSpiral(matrix);
            PrintMatrix(matrix);
        }

        static void FillMatrixSpiral(int[,] matrix)
        {
            int value = 1;
            int top = 0, bottom = m - 1;
            int left = 0, right = n - 1;

            while (value <= m * n)
            {
                // Вправо по верхней строке
                for (int i = left; i <= right && value <= m * n; i++)
                    matrix[top, i] = value++;

                top++;

                // Вниз по правому столбцу
                for (int i = top; i <= bottom && value <= m * n; i++)
                    matrix[i, right] = value++;

                right--;

                // Влево по нижней строке
                for (int i = right; i >= left && value <= m * n; i--)
                    matrix[bottom, i] = value++;

                bottom--;

                // Вверх по левому столбцу
                for (int i = bottom; i >= top && value <= m * n; i--)
                    matrix[i, left] = value++;

                left++;
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}