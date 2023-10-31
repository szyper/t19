namespace _4_project_1_try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj dwie liczby\n");
                Console.Write("Podaj a:");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Podaj y:");
                int y = int.Parse(Console.ReadLine());
                /*if (y == 0)
                {
                    throw new Exception("\nNie można dzielić przez 0");
                }*/
                int result = x / y;
                Console.Write($"Wynik dzielenia {x} / {y} = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{result:F3}");
                Console.ResetColor();
            }
            catch (DivideByZeroException)
            {
                ErrorColorChange("Nie można dzielić przez 0");
            }
            catch (FormatException)
            {
                ErrorColorChange("Błędny format danych, podaj liczbę zmiennoprzecinkową lub całkowitą");

            }
            catch (OverflowException)
            {
                ErrorColorChange($"Podana liczba jest błędna, podaj dane z zakresu <{int.MinValue} ; {int.MaxValue}>");

            }
            catch (Exception ex)
            {
                ErrorColorChange("{ex.Message}");
            }
        }

        static void ErrorColorChange(string comment)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine($"\nBłąd: {comment}");
            Console.ResetColor();
        }
    }
}