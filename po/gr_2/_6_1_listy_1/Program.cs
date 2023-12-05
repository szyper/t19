namespace _6_1_listy_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tworzenie listy liczb całkowitych
            List<int> ints = new List<int>();

            //tworzenie listy liczb całkowitych z początkowymi elementami, używając inicjalizatora kolekcji
            List<int> ints1 = new List<int>() { 1, 2, 1, 10, -2 };

            //dodawanie elementó do listy za pomocą metody Add()
            ints1.Add(1);
            ints1.Add(111);

            //usuwanie elementu z listy za pomocą metody Remove()
            ints1.Remove(1);

            //wyświetlenie długości listy za pomocą właściwości Count
            Console.WriteLine("Długość listy: " + ints1.Count); //6

            //wyświetlenie elementów listy
            foreach (int i in ints1)
            {
                Console.Write($"{i} "); //2 1 10 -2 1 111
            }

            ints1.Remove(1);
            foreach (int i in ints1)
            {
                Console.Write($"{i} "); //2 10 -2 1 111
            }
        }
    }
}