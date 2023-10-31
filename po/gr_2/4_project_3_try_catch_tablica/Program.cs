namespace _4_project_3_try_catch_tablica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            bool isCorrect = false;

            do
            {
                Console.WriteLine("Wprowadź 5 liczb całkowitych");
                try
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write($"Podaj liczbę {i + 1}:");
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    isCorrect = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nNieprawidłowe dane. Wprowadź poprawną liczbę całkowitą.\n");
                }
                catch(OverflowException)
                {
                    Console.WriteLine($"\nNieprawidłowe dane. Liczba poza zakresem <{int.MinValue} ; {int.MaxValue}>\n");
                }
            }
            while (!isCorrect);

            int index = 0;
            string input;

            do
            {
                Console.Write("\nWprowadź indeks tablicy lub q, aby zakończyć program:");
                input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    index = int.Parse(input);

                    if (index > array.Length - 1 || index < 0)
                    {
                        throw new OverflowException("Błąd: !!!");
                    }

                    Console.WriteLine($"\nLiczba pod indeksem {index} to {array[index]}\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nNieprawidłowe dane. Wprowadź poprawną liczbę całowitą\n");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"\nNieprawidłowe dane. Indeks musi być między 0 a <{array.Length - 1}>\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"\nNieprawidłowe dane. Indeks musi być między 0 a  <{array.Length - 1}>\n");
                }
            }
            while (true);
        }
    }
}