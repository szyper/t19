namespace _5_project_tablica_dwuwymiarowa_3_wymiarowa_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = new int[4, 3];
            Console.WriteLine(ints.Rank); //2
            Console.WriteLine(ints.GetLength(0)); //4
            Console.WriteLine(ints.GetLength(1)); //3
            //Console.WriteLine(ints.GetLength(2));
            Console.WriteLine();

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write($"ints[{i},{j}]={ints[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,,] cubs = new int[4, 3, 2];
            for (int i = 0; i < cubs.GetLength(0); i++)
            {
                Console.WriteLine($"cubs[{i}]");
                for(int j = 0; j < cubs.GetLength(1); j++)
                {
                    Console.WriteLine($"\tcubs[{i},{j}]");
                    for( int k = 0; k < cubs.GetLength(2); k++)
                    {
                        Console.WriteLine($"\t\tcubs[{i},{j},{k}]");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"matrix[{i},{j}]={matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            double[,,] cube = new double[,,] { { { 1.0, 2.0, 3.0 }, { 4.0, 5.0, 6.0 } },{ { 7.0, 8.0, 9.0 },{ 10.0, 11.0, 12.0} } };
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                Console.WriteLine($"cube[{i}]");
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    Console.WriteLine($"\tcube[{i},{j}]");
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        Console.WriteLine($"\t\tcube[{i},{j},{k}]={cube[i,j,k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}