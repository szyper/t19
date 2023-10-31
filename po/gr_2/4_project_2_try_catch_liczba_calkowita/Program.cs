namespace _4_project_2_try_catch_liczba_calkowita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Napisz program w C#, który wczytuje liczbę całkowitą od użytkownika i oblicza jej pierwiastek kwadratowy.
            Jeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
            Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. 
            Program powinien działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch-finally do obsługi wyjątków.
             */

            string input;

            do
            {
                Console.Write("Podaj liczbę całkowitą lub 0, aby wyjść z programu:");
                input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }

                try
                {
                    int number = int.Parse(input);
                    if (number < 0)
                    {
                        throw new ArgumentOutOfRangeException("Liczba nie może być ujemna");
                    }

                    if (number > 0)
                    {
                        double sqrt = Math.Sqrt(number);
                        Console.WriteLine($"\nPierwiastek z {number} wynosi {sqrt}\n\n");
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"\nBłąd: {ex.ParamName}\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nNieprawidłowe dane wejściowe. Podaj prawidłową liczbę całkowitą\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Nieprawidłowe dane wejściowe. Przekroczono zakres liczby <{int.MinValue} ; {int.MaxValue}>\n");
                }
                finally 
                {
                    Console.WriteLine("\nDziękujemy za skorzystanie z programu\n\n");
                }
            } 
            while (input != "q");
            
            
        }
    }
}