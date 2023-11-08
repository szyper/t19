using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System;

namespace _5_project_tablice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //incjalizacja tablicy podczas jej deklaracji
            int[] tabInt = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(tabInt[0]); //1
            Console.WriteLine(tabInt[tabInt.Length - 1]); //6

            //deklaracja tablicy
            int[] tabInt2 = new int[5];
            tabInt2[0] = 1;
            tabInt2[1] = 2;
            tabInt2[2] = 33;
            tabInt2[3] = -1;
            tabInt2[4] = 10;

            /*foreach (int i in tabInt2)
            {
                Console.Write($"{i} ");
            }*/

            /*Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy.Następnie program wyświetla sumę wszystkich elementów tablicy.*/

            /*int[] tabInt3 = new int[5];
            int sum = 0;

            for (int i = 0; i < tabInt3.Length; i++)
            {
                Console.Write("Podaj liczbę całkowitą:");
                tabInt3[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0;i < tabInt3.Length; i++)
            {
                sum += tabInt3[i];
            }

            Console.WriteLine($"\nSuma elementów tablicy wynosi: {sum}\n\n");*/




            /*
             Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. Następnie program wyświetla sumę wszystkich elementów tablicy.

                        W celu zabezpieczenia programu przed niepoprawnymi danymi wejściowymi, użyliśmy metody int.TryParse(), która pozwala na sprawdzenie, czy wprowadzona wartość jest liczbą całkowitą. Jeśli użytkownik wprowadzi niepoprawną wartość, program wyświetli stosowny komunikat i poprosi o ponowne wprowadzenie liczby.
             */


            /*int[] numbers = new int[5];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Podaj liczbę całowitą:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Niepoprawna wartość. Wprowadź liczbę całkowitą");
                    i--;
                }
            }

            for (int i = 0;i < numbers.Length;i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"\nSuma wszystkich elementów tablicy wynosi: {sum}\n\n");*/


            /*Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy, a następnie wyświetla sumę wszystkich elementów tablicy.
                Zadeklaruj tablicę o rozmiarze 5 i nazwij ją numbers.
                Użyj pętli for, aby pobrać od użytkownika 5 liczb całkowitych i zapisać je w tablicy numbers.
                Wyświetl na ekranie komunikat, który prosi użytkownika o podanie kolejnej liczby całkowitej i użyj metody GetIntegerFromUser(), aby ją pobrać i zweryfikować.
                Zdefiniuj metodę GetIntegerFromUser(), która przyjmuje od użytkownika liczbę całkowitą i zwraca ją.Jeśli użytkownik wprowadzi niepoprawną wartość, metoda wyświetli stosowny komunikat i poprosi o ponowne wprowadzenie liczby.
                Użyj metody int.TryParse(), aby sprawdzić, czy wprowadzona wartość jest poprawną liczbą całkowitą i przypisać ją do zmiennej input.
                Zdefiniuj metodę CalculateSum(int[] numbers), która przyjmuje tablicę liczb całkowitych i zwraca ich sumę.
                Użyj pętli foreach, aby dodać do sumy każdy element tablicy numbers i zwrócić sumę.
                Wywołaj metodę CalculateSum(numbers) i przypisz jej wynik do zmiennej sum.
                Wyświetl na ekranie komunikat, który pokazuje sumę podanych liczb.*/

            int[] numbers = new int[5];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = GetIntegerFromUser();
            }

            sum = CalculateSum(numbers);
            Console.WriteLine($"\nSuma wszystkich elementó tablicy wynosi: {sum}\n\n");


            /*
             wbudowana funkcja Sum()
            */
            int[] tabInt3 = { 2, 3, 4 };
            int sum2 = tabInt3.Sum();
            Console.WriteLine(sum2);




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
                
                Console.WriteLine("Niepoprawana wartość. Wprowadź liczbę całkowitą");
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