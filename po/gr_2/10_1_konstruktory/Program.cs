using _10_1_konstruktory.classes;

namespace _10_1_konstruktory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person p1 = new Person("Janusz", "Nowak");
      Console.WriteLine(p1.FirstName);
    }
  }
}
