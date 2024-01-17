using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInt("Podaj liczbę osób:", 0, int.MaxValue);
            Console.WriteLine();

            string[] names = new string[n];
            int[] ages = new int[n];

            for (int i = 0; i < n; i++)
            {
                names[i] = ReadString($"Podaj imię osoby {i + 1}:");
                ages[i] = ReadInt($"Podaj wiek osoby {i + 1}:", 0, 150);
            }

            //List<string> namesStartsWithA = names.Where(e => e.StartsWith("A")).ToList();
            List<string> namesStartsWithA = names.Where(name => name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine("\nTablica imion i wieków:");
            PrintArray(names, ages);

            Console.WriteLine("\nLista imion rozpoczynających się na literę A lub a:");
            PrintList(namesStartsWithA);

            Dictionary<string, int> adults = new Dictionary<string, int>();
            for (int i = 0; i < names.Length; i++)
            {
                if (ages[i] >= 18)
                {
                    adults.Add(names[i], ages[i]);
                }
            }

            Console.WriteLine("\nSłownik osób pełnoletnich:");
            PrintDictionary(adults);

            Console.ReadKey();
        }

        private static void PrintDictionary(Dictionary<string, int> adults)
        {
            foreach (var item in adults)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        private static void PrintList(List<string> namesStartsWithA)
        {
            foreach (string name in namesStartsWithA)
            {
                Console.WriteLine(name);
            }
        }

        private static void PrintArray(string[] names, int[] ages)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]} - {ages[i]}");
            }
        }

        static int ReadInt(string prompt, int low, int high)
        {
            int result;
            bool valid;
            do
            {
                Console.Write(prompt);
                valid = int.TryParse(Console.ReadLine(), out result) && result >= low && result <= high;
                if (!valid)
                {
                    Console.WriteLine($"Podaj liczbę z zakresu {low} - {high}");
                }
            } while (!valid);
            return result;
        }

        static string ReadString(string prompt)
        {
            string result;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
                if (string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Podaj niepusty ciąg znaków");
                }
            } while (string.IsNullOrEmpty(result));
            return result;
        }

        
    }
}
