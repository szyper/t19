namespace _5_project_tablica_dwuwymiarowa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = new int[3, 3];
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write($"ints[{i},{j}]={ints[i, j]} ");
                }
                Console.WriteLine("|");
            }
            
            Console.WriteLine(ints.GetLength(0)); //3
            Console.WriteLine(ints.GetLength(1)); //3
            //Console.WriteLine(ints.GetLength(2)); //3

            Console.WriteLine(ints.Rank); //tablica 2-wymiarowa
            Console.WriteLine();

            int[,,] cubs = new int[3, 3, 4];

            for (int i = 0; i < cubs.GetLength(0); i++)
            {
                Console.WriteLine($"cubs[{i}]");
                for (int j = 0; j < cubs.GetLength(1); j++)
                {
                    Console.WriteLine($"\tcubs[{i},{j}]");
                    for(int k = 0; k < cubs.GetLength(2); k++)
                    {
                        Console.Write($"\t\tcubs[{i},{j},{k}]={cubs[i,j,k]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine(cubs.Rank);

            int[,] matrix = new int[,] { { 1 ,2, 3}, { 4, 5, 6}, { 7, 8, 9} };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"matrix[{i},{j}]={matrix[i, j]} ");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine(matrix.Rank);
            //dokończyć inicjalizację tablicy 3-wymiarowej




        }
    }
}