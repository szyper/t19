using _10_1_konstruktory.classes;

namespace _10_1_konstruktory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person nowak = new Person("Jan", "Nowak");
      Console.WriteLine(nowak.FirstName);

    }
  }
}
