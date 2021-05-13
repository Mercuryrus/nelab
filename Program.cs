using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int rowa, cola, rowb, colb;
            do
            {

                do
                {
                    Console.Write("Строки для БНВ: ");
                } while (!int.TryParse(Console.ReadLine(), out rowa));
            } while (rowa <= 0);

            do
            {
                do
                {
                    Console.Write("Столбы для Маркообразных: ");
                } while (!int.TryParse(Console.ReadLine(), out cola));
            } while (cola <= 0);



            int[,] a = new int[rowa, cola];
            for (int i = 0; i < rowa; i++)
            {
                for (int j = 0; j < cola; j++)
                {
                    Console.Write("Введите значения({0},{1}): ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            do
            {
                do
                {
                    Console.Write("Строки для БНВ: ");
                } while (!int.TryParse(Console.ReadLine(), out rowb));
            } while (rowb <= 0);
            do
            {
                do
                {
                    Console.Write("Столбы для Маркообразных: ");
                } while (!int.TryParse(Console.ReadLine(), out colb));
            } while (colb <= 0);

            int[,] b = new int[rowb, colb];
            for (int i = 0; i < rowb; i++)
            {
                for (int j = 0; j < colb; j++)
                {
                    Console.Write("Введите значения({0},{1}): ", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < a.GetLength(0); i++, Console.WriteLine())
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("|{0,3} |", a[i, j]);
                }
            }
            Console.WriteLine();

            for (int i = 0; i < b.GetLength(0); i++, Console.WriteLine())
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write("|{0,3} |", b[i, j]);
                }
            }
            Console.WriteLine();

            if (rowa <= rowb || rowa <= rowb)
            {
                for (int i = 0; i < rowa; i++, Console.WriteLine())
                {
                    for (int j = 0; j < cola; j++)
                    {
                        int[,] result = new int[rowa, cola];
                        result[i, j] = a[i, j] + b[i, j];
                        Console.Write("|{0,3} |", result[i, j]);
                    }

                }

                for (int i = 0; i < rowb; i++, Console.WriteLine())
                {
                    for (int j = 0; j < colb; j++)
                    {
                        int[,] resultb = new int[rowb, colb];
                        resultb[i, j] = a[i, j] + b[i, j];
                        Console.WriteLine("|{0,3} |", resultb[i, j]);
                    }
                }
            }
        }
    }
}