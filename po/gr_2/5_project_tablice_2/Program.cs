using System.Diagnostics;

namespace _5_project_tablice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabA = CreateArray("tabA");
            SetArray(tabA, "tabA");
            DisplayArray(tabA, "tabA");

        }

        public static int[] CreateArray(string name)
        {
            Console.Write("Podaj rozmair tablicy {0}:", name);
            int size = 0;
            try
            {
                size = int.Parse(Console.ReadLine());
                if (size <= 0) throw new ArgumentException("Rozmiar tablicy musi być dodatni"); 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Wystąpił błąd: {0}", ex.Message);
                return null;
            }
            int[] array = new int[size];
            return array;
        }

        public static void SetArray(int[] array, string name)
        {
            Console.WriteLine("\nPodaj elementy tablicy {0}", name);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{1}[{0}] = ", i, name);
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void DisplayArray(int[] array, string name)
        {
            Console.WriteLine("\nZawartość tablicy {0}:", name);
            for(int i = 0;i < array.Length; i++)
            {
                Console.WriteLine($"{name}[{i}] = {array[i]}");
            }
        }
    }
}