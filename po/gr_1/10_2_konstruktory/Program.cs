using _10_2_konstruktory.classes;
using System.Runtime.Serialization;

namespace _10_2_konstruktory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person person1 = new Person("Janusz");
      Person person2 = new Person("Anna");
      Person person3 = new Person();
      Person person4 = new Person("Paweł", "Kowal");
      Person person5 = new Person("Krystyna", "Pawlak", 20, 190);

      //wyświetlenie wartości pól obiektów
      Console.WriteLine("Obiekt person1: {0}, {1}, {2}", person1.Name, person1.Surname, person1.Age);
      Console.WriteLine("Obiekt person3: {0}, {1}, {2}", person3.Name, person3.Surname, person3.Age);
      Console.WriteLine("Obiekt person4: {0}, {1}, {2}", person4.Name, person4.Surname, person4.Age);
      Console.WriteLine("Obiekt person5: {0}, {1}, {2}, wzrost: {3}", person5.Name, person5.Surname, person5.Age, person5.Height);

      //wyświetlenie liczby obiektów klasy Person
      Console.WriteLine("Liczba obiektów klasy Person: {0}", Person.Counter);

    }
  }
}