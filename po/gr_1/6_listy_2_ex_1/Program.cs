namespace _6_listy_2_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            //tworzenie obiektu generatora liczb losowych
            Random rnd = new Random();

            //wypełnienie listy 10 losowymi liczbami z zakresu 1-100
            for (int i = 0; i < 10; i++)
            {
                lista.Add(rnd.Next(1, 100 + 1));
            }

            Console.WriteLine("Lista liczb losowych:");
            foreach (int i in lista)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            //wywołanie metody, która zwraca listę liczb podzielnych przez 3 lub 5
            List<int> listDivisibleBy3Or5 = divisibleBy3Or5(lista);

            //wyświetlenie listy z elementami podzielnymi przez 3 lub 5
            Console.WriteLine("\nLista z elementami podzielnymi przez 3 lub 5:");
            foreach (int i in listDivisibleBy3Or5)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        //metoda, która przyjmuje listę liczb i zwraca listę liczb podzielnych przez 3 lub 5
        static List<int> divisibleBy3Or5(List<int> lista)
        {
            //tworzenie pustej listy
            List<int> result = new List<int>();

            //iterowanie po elementach listy i sprawdzenie warunku podzielności
            foreach (int i in lista)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result.Add(i);
                }
            }

            return result;
        }

    }
}