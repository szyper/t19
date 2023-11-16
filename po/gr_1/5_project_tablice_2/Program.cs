namespace _5_project_tablice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabA = CreateArray("tabA");
            if (tabA != null)
            {
                SetArray(tabA, "tabA");
                Console.WriteLine();
                DisplayArray(tabA, "tabA");
            }
        }

        public static int[] CreateArray(string name)
        {
            Console.Write($"Podaj rozmiar tablicy <0 ; {int.MaxValue}> {name}:");
            int size = 0;
            try
            {
                size = int.Parse(Console.ReadLine());
                if (size <= 0) throw new ArgumentException("rozmiar tablicy musi być dodatni");
            }
            catch(ArgumentException e )
            {
                Console.WriteLine("\nWystąpił błąd: {0}\n\n", e.Message);
                return null;
            }
            
            int[] array = new int[size];
            return array;
        }
       
        public static void SetArray(int[] array, string name)
        {
            Console.WriteLine($"\nPodaj elementy tablicy {name}");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Podaj element tablicy {i+1}:");
                try
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e )
                {
                    Console.WriteLine("\nWystąpił błąd: {0}\n", e.Message);
                    i--;
                }
            }
        }
        public static void DisplayArray(int[] array, string name)
        {
            Console.WriteLine($"\nWyświetlenie zawartości tablicy {name}:");
            int i = 0;
            foreach (var element in array)
            {
                Console.WriteLine($"{name}[{i}]: {element}");
                i++;
            }
        }
    }
}