namespace _7_1_slowniki
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Dictionary<int, string> slownik = new Dictionary<int, string>();
      slownik.Add(1, "Franek");
      slownik.Add(2, "Anna");
      slownik.Add(3, "Tomasz");

      foreach (var item in slownik)
      {
        Console.WriteLine($"{item.Value}");
      }

      Console.WriteLine();

      //tworzymy słownik, który przechowuje łańcuchy jako klucze i liczby jako wartości
      Dictionary<string, int> slownik1 = new Dictionary<string, int>();

      //Dodajemy kilka par klucz-wartość do słownika
      slownik1.Add("jeden", 1);
      slownik1.Add("dwa", 2);
      slownik1.Add("trzy", 3);

      //wyświetlenie zawartości słownika za pomocą pętli foreach
      //foreach (var pair in slownik1)
      foreach (KeyValuePair<string, int> pair in slownik1)
      {
        Console.WriteLine("Klucz: {0}, wartość: {1}", pair.Key, pair.Value);
      }
      Console.WriteLine();

      //##################################################################################

      //Utwórz słownik, który może przechowywać łańcuchy jako klucze i wartości
      Dictionary<string, string> capital = new Dictionary<string, string>();

      //Dodaj kilka par klucz-wartość do słownika za pomocą składni inicjalizatora kolekcji
      capital = new Dictionary<string, string>()
            {
                { "Polska", "Warszawa"},
                { "Niemcy", "Berlin"},
                { "Francja", "Paryż"},
                { "Włochy", "Rzym"}
            };

      foreach (var pair in capital)
      {
        Console.WriteLine("Kraj: {0}, stolica: {1}", pair.Key, pair.Value);
      }
      Console.WriteLine();

      //##################################################################################

      Dictionary<string, string> phones = new Dictionary<string, string>();

      phones.Add("+48 123 456 789", "Katarzyna");
      phones.Add("+48 123 444 789", "Tomasz");
      phones.Add("+48 123 456 555", "Anna");

      //foreach (string phone in phones) //error!
      foreach (KeyValuePair<string, string> phone in phones)
      {
        Console.WriteLine("Numer telofonu: {0}, osoba: {1}", phone.Key, phone.Value);
      }
      Console.WriteLine();

      foreach (string phone in phones.Keys)
      {
        Console.WriteLine("Numer telofonu: {0}, osoba: {1}", phone, phones[phone]);
      }
      Console.WriteLine();

      //##################################################################################

      Dictionary<string, string> animals = new Dictionary<string, string>();
      animals = new Dictionary<string, string>()
            {
                {"pies", "hauhau" },
                {"kot", "miaumiau" },
                {"krowa", "muu" },
                {"koń", "iha" },
            };

      foreach (var animal in animals)
      {
        Console.WriteLine("Zwierzę: {0}, dźwięk: {1}", animal.Key, animal.Value);
      }
      Console.WriteLine();

      //##################################################################################

      Dictionary<string, string> colors = new Dictionary<string, string>();

      colors.Add("biały", "#FFFFFF");
      colors.Add("czarny", "#000000");
      colors.Add("czerwony", "#FF0000");
      colors.Add("zielony", "#00FF00");
      colors.Add("niebieski", "#0000FF");

      foreach (var color in colors)
      {
        Console.WriteLine("Kolor: {0}, hex: {1}", color.Key, color.Value);
      }
      Console.WriteLine();

      //##################################################################################

      Dictionary<string, string> data = new Dictionary<string, string>();

      //poproś użytkownika o podanie liczby par klucz-
      Console.Write("Podaj ile par klucz-wartość chcesz wprowadzić:");
      int n = int.Parse(Console.ReadLine());

      //w pętli pobierzemy od użytkownika klucz i wartość następnie dodamy do słownika
      for (int i = 0; i < n; i++)
      {
        Console.Write("Podaj klucz:");
        string key = Console.ReadLine();
        Console.Write("Podaj wartość:");
        string value = Console.ReadLine();
        data.Add(key, value);
      }

      foreach (var item in data)
      {
        Console.WriteLine("Klucz: {0}, wartość: {1}", item.Key, item.Value);
      }
      Console.WriteLine();
    }
  }
}