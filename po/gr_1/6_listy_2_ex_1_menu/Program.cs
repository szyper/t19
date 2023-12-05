namespace _6_listy_2_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            //tworzenie obiektu generatora liczb losowych
            Random rnd = new Random();

            //wypełnienie listy 10 losowymi liczbami z zakresu 1-100
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(1, 100 + 1));
            }

            Console.WriteLine("Lista liczb losowych:");
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            //tworzenie zmiennej przechowującej wybór użytkownika
            int choice;

            //tworzenie pętli do wyświetlania menu o obsługi wyboru
            do
            {
                //wyświetlenie menu
                Console.WriteLine("1. Wyświetlić listę liczb podzielnych przez 3 lub 5");
                Console.WriteLine("2. Wyświetlić listę liczb nieparzystych");
                Console.WriteLine("3. Wyświetlić listę liczb posortowanych rosnąco");
                Console.WriteLine("4. Wyświetlić listę liczb posortowanych malejąco");
                Console.WriteLine("5. Wyjść z programu\n");

                //pobieranie wyboru użytkownika
                Console.Write("Podaj swój wybór:");
                choice = int.Parse(Console.ReadLine());

                //wykonywanie akcji w zależnośći od wyboru
                switch (choice)
                {
                    case 1:
                        //wywołanie metody, która zwraca listę liczb podzielnych przez 3 lub 5
                        List<int> divisible = DivisibleBy3Or5(list);

                        //wyświetlenie wynikowej listy
                        Console.WriteLine("Lista liczb podzielnych przez 3 lub 5");
                        foreach (int i in divisible)
                        {
                            Console.Write($"{i} ");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        //wywołanie metody, która zwraca listę liczb posortowanych nieparzystych
                        List<int> odd = Odd(list);

                        //wyświetlenie wynikowej listy
                        Console.WriteLine("Lista liczb nieparzystych:");
                        foreach (int i in odd)
                        {
                            Console.Write($"{i} ");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        //wywołanie metody, która zwraca listę liczb posortowanych rosnąco
                        List<int> ascending = Ascending(list);
                        //dokończyć
                        break;
                }
            }
            while (choice != 5);


            //wywołanie metody, która zwraca listę liczb podzielnych przez 3 lub 5
            List<int> listDivisibleBy3Or5 = DivisibleBy3Or5(list);

            //wyświetlenie listy z elementami podzielnymi przez 3 lub 5
            Console.WriteLine("\nLista z elementami podzielnymi przez 3 lub 5:");
            foreach (int i in listDivisibleBy3Or5)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        //metoda, która przyjmuje listę liczb i zwraca listę liczb podzielnych przez 3 lub 5
        static List<int> DivisibleBy3Or5(List<int> lista)
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

        //metoda, która przyjmuje listę liczb i zwraca listę liczb nieparzystych
        static List<int> Odd(List<int> list) 
        {
            //tworzenie pustej listy
            List<int> result = new List<int>();

            //iteracja po elementach listy i sprawdzanie warunku nieparzystości
            foreach (int i in list)
            {
                if (i % 2 != 0)
                {
                    //dodawanie liczb do listy wynikowej
                    result.Add(i);
                }
            }
            //zwracanie listy wynikowej
            return result;
        }

        //metoda, która przyjmuje listę liczb i zwraca listę liczb posortowanych rosnąco
        static List<int> Ascending(List<int> list)
        {
            //tworzenie kopii listy
            List<int> result = new List<int>(list);

            //sortowanie listy rosnąco
            result.Sort();

            //zwracanie listy wynikowej
            return result;
        }

    }
}