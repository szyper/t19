using _10_2_konstruktory.classes;

namespace _10_2_konstruktory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person p1 = new Person();
      Person p2 = new Person();
      Person p3 = new Person("Janusz");
      Person p4 = new Person("Janusz", "Nowak");
      Person p5 = new Person("Janusz", "Nowak", 20);
      Person p6 = new Person("Anna", "Kowal", 22, 177);

      //wyświetlenie wartości właściwości
      Console.WriteLine("\n\n" + p1.GetData());
      Console.WriteLine(p3.GetData());
      Console.WriteLine(p6.GetData() + ", wzrost: " + p6.Height);

      //wyświetlenie liczby obiektów klasy Person
      Console.WriteLine("\n\nLiczba obiektów klasy Person: {0}", Person.Counter); //7

    }
  }
}
