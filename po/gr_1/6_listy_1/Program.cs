namespace _6_listy_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tworzenie listy liczb całkowitych
            List<int> ints = new List<int>();
            
            //tworzenie listy liczb całkowitych z początkowymi elementami, używając inicjalizatora kolekcji
            //List<int> ints1 = new List<int>() { 1, 2, 3, 10};

            //dodawanie elementów do listy za pomocą metody Add()
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);

            //usuwanie elementu z listy za pomocą metody Remove()
            ints.Remove(2);

            //wyświetlenie długości listy za pomocą właściwości Count
            Console.WriteLine("Długość listy: " + ints.Count);

            //wyświetlenie elementów listy
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }



        }
    }
}