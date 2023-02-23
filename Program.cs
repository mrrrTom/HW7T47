// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

namespace HW47
{
    class ConsoleApp
    {
        static void Main()
        {
            var arr = InitializeRadomArray(3, 4);
            Console.WriteLine(arr.ToArrString());
        }

        static double[,] InitializeRadomArray(int row, int col)
        {
            var result = new double[row, col];
            var rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    var signPow = rnd.Next(1, 3);
                    var tenPow = rnd.Next(0, 3);
                    var doubleValue = rnd.NextDouble();
                    var sign = ((double)Math.Pow(-1, signPow));
                    var tens = ((double)Math.Pow(10, tenPow));
                    var arrInput = doubleValue * sign * tens;
                    var roundCount = rnd.Next(0, 3);
                    result[i, j] = Math.Round(arrInput, roundCount);
                }
            }

            return result;
        }
    }

    public static class ArrExtension
    {
        public static string ToArrString(this double[,] arr)
        {
            var result = string.Empty;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    result += arr[i, j] + "\t";
                }

                result += "\n";
            }

            return result;
        }
    }
}