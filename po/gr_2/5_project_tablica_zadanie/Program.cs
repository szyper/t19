using System.Diagnostics;

namespace _5_project_tablica_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region code
            //ReadNumber();

            
            int[,] ints = CreateArray(3, 3);
            FillArray(ints, 1, 10);
            DisplayArray(ints);
            Console.WriteLine("Suma elementów na przekątnej tablicy ints wynosi: {0}", CalculateSum(ints));

            //Console.WriteLine(ints[1, 1]);

            //Random random = new Random();
            //Console.WriteLine(random.Next(1, 2 + 1)); //<1; 2) => <1;3)


            #endregion

        }

        static int ReadNumber()
        {
            int number;

            while (true)
            {
                Console.Write("Podaj wartość:");
                string? input = Console.ReadLine();

                if (input == "q")
                {
                    Console.WriteLine("Zakończono program");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }

                bool success = int.TryParse(input, out number);

                if (success && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.Write("Podana wartość nie jest poprawną liczbą dodatnią. Spróbuj ponownie lub wpisz q, aby zakończyć program:");
                }
            }
        }

        static int[,] CreateArray(int rows, int cols)
        {
            return new int[rows, cols];
        }

        static int[,] FillArray(int[,] array, int min, int max)
        {
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(min, max + 1);
                }
            }
            return array;
        }

        static void DisplayArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int CalculateSum(int[,] array)
        {
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, i];
            }

            return sum;
        }
    }
}