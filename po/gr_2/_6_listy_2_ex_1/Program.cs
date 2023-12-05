namespace _6_listy_2_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //tworzenie listy liczb całowitych
           List<int> list = new List<int>();

            //tworzenie obiektu generatora liczb losowych
            Random rnd = new Random();

            //wywołanie listy 10 losowych liczb z zakresu 1-100
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(1, 100 + 1));
            }

            //wyświetlanie listy
            Console.WriteLine("Lista liczb losowych:");
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            //wywołanie metody, która zwraca listę liczb podzielnych przez 3 lub 5
            List<int> divisibleBy3Or5 = DivisibleBy3Or5(list);

            //wyświetlenie wynikowej listy
            Console.WriteLine("Lista liczb podzielnych przez 3 lub 5:");
            foreach (int i in divisibleBy3Or5)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        //metoda, która przyjmuje listę liczb i zwraca listę liczb podzielnych przez 3 lub 5
        static List<int> DivisibleBy3Or5(List<int> list)
        {
            //tworzenie pustej listy
            List<int> result = new List<int>();

            //iterowanie po elementach listy i sprawdzanie warunku podzielności
            foreach (int i in list)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result.Add(i);
                }
            }
            //zwracanie listy wynikowej
            return result;
        }

    }
}