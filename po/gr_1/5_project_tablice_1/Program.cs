namespace project_7_tablice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklaracja tablicy
            int[] tabInt = new int[5];
            //tabInt = { 1, 2, 10, 20, 40 };
            //inicjalizacja tablicy
            tabInt[0] = 1;
            tabInt[1] = 2;
            tabInt[2] = 10;
            tabInt[3] = 20;
            tabInt[4] = 40;

            //inicjalizacja tablicy podczas jej deklaracji
            int[] tabInt2 = { 1, 2, 30, 40, 5 };






            /*Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy.Następnie program wyświetla sumę wszystkich elementów tablicy.*/

            int[] tabInt3 = new int[10];
            int sum = 0;

            for (int i = 0; i < tabInt.Length; i++)
            {
                Console.Write("Podaj liczbę całkowitą:");
                tabInt3[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tabInt3.Length; i++)
            {
                sum += tabInt3[i];
            }

            Console.WriteLine($"\nSuma elementów tablicy wynosi: {sum}\n\n");





            /*
             Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. Następnie program wyświetla sumę wszystkich elementów tablicy.

            W celu zabezpieczenia programu przed niepoprawnymi danymi wejściowymi, użyliśmy metody int.TryParse(), która pozwala na sprawdzenie, czy wprowadzona wartość jest liczbą całkowitą. Jeśli użytkownik wprowadzi niepoprawną wartość, program wyświetli stosowny komunikat i poprosi o ponowne wprowadzenie liczby.
             */

                        int[] numbers = new int[5];
                        int sum = 0;

                        for(int i = 0;i < numbers.Length; i++)
                        {
                            Console.Write("Podaj liczbę całkowitą:");
                            string input = Console.ReadLine();

                            if (int.TryParse(input, out int number))
                            {
                                numbers[i] = number;
                            }
                            else
                            {
                                Console.WriteLine("Niepoprawna wartość. Wprowadź liczbę całowitą");
                                i--;
                            }
                        }

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            sum += numbers[i];
                        }

                        Console.WriteLine($"\nSuma wszystkich elementów tablicy wynosi: {sum}\n\n");




            /*
                        Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy, a następnie wyświetla sumę wszystkich elementów tablicy.Kod ten wykorzystuje metodę GetIntegerFromUser(),
            która pobiera od użytkownika liczbę całkowitą i zwraca ją.
            Jeśli użytkownik wprowadzi niepoprawną wartość, funkcja wyświetli stosowny komunikat i poprosi o ponowne wprowadzenie liczby. 
            Funkcja CalculateSum(int[] numbers) przyjmuje tablicę liczb całkowitych i zwraca ich sumę.*/

            int[] numbers = new int[5];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = GetIntegerFromUser();
            }

            sum = CalculateSum(numbers);
            Console.WriteLine($"\nSuma wszystkich elementów tablicy wynosi: {sum}\n\n");


            /*
             wbudowana funkcja Sum()
             */

            int[] tabInt3 = { 1, 2, 30 };
            int sum = tabInt3.Sum();
            Console.WriteLine(sum);


        }

        static int GetIntegerFromUser()
        {
            while (true)
            {
                Console.Write("Podaj liczbę całkowitą:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Niepoprawna wartość. Wprowadź liczbę całkowitą");
                }
            }
        }

        static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            for(int i = 0;i < numbers.Length;i++) 
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}