using _10_3_konstruktory.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3_konstruktory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
      Animal a = new Animal("Burek");
      Console.WriteLine(a.Describe());
      a.BirthDate = new DateTime(2020, 2, 3);
      Console.WriteLine(a.Describe());
      a.ShowAge();
      */

      /*
      Animal a2 = new Animal("Kot", new DateTime(2018, 1, 20));
      Console.WriteLine(a2.Describe());
      a2.ShowAge();

      Animal a3 = new Animal("pies", new DateTime(2000, 1, 20), true);
      Console.WriteLine(a3.Describe());
      a3.ShowAge();

      //dodaj papugę
      Animal a4 = new Animal("ara", new DateTime(2001, 10, 11), false, Kind.Ptak);
      Console.WriteLine(a4.Describe());
      a4.ShowAge();
      */

      //tworzenie listy zwierząt
      List<Animal> animals = new List<Animal>();

      //wyświetlenie menu głównego
      ShowMainMenu(animals);

      Console.ReadKey();
    }
    //metoda wyświetlająca menu główne
    static void ShowMainMenu(List<Animal> animals)
    {
      //wyczyszczenie konsoli
      Console.Clear();

      //wyświetlenie opcji menu
      Console.WriteLine("Witaj w programie do zarządzania zwierzętami");
      Console.WriteLine("1. Dodaj zwierzę");
      Console.WriteLine("2. Pokaż listę zwierząt");
      Console.WriteLine("3. Pokaż szczegóły zwierzęcia");
      Console.WriteLine("4. Usuń zwierzę");
      Console.WriteLine("5. Zakończ program\n");
      Console.Write("Wybierz jedną z opcji:");

      //wczytanie wyboru użytkownika
      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          //wywołanie metody dodającej zwierzę
          AddNewAnimal(animals);
          break;
        case "2":
          //wywołanie metody pokazującej listę zwierząt
          ShowAnimalList(animals);
          break;
        case "3":
          //wywołanie metody pokazującej szczegóły zwierzęcia
          ShowAnimalDetails(animals);
          break;
        case "4":
          //wywołanie metody usuwającej zwierzę
          RemoveAnimal(animals);
          break;
        case "5":
          //zakończenie programu
          Console.WriteLine("Dziękujemy za skorzystanie z programu");
          return;
        default:
          //nieprawidłowy wybór
          Console.WriteLine("Niepoprawna opcja. Naciśnij dowolny klawisz, aby spróbować ponownie");
          Console.ReadKey();
          ShowMainMenu(animals);
          break;
      }
    }

    //metoda usuwająca zwierzę
    private static void RemoveAnimal(List<Animal> animals)
    {
      Console.Clear();

      //sprawdzenie czy lista jest pusta
      if (animals.Count == 0)
      {
        Console.WriteLine("Nie ma żadnych zwierząt na liście");
      }
      else
      {
        //wyświetlenie podmenu z opcjami usuwania
        Console.WriteLine("1. Usuń wszystkie zwierzęta");
        Console.WriteLine("2. Usuń jedno zwierzę");

        Console.Write("\nWybierz jedną z opcji:");

        //wczytanie wyboru użytkownika
        string choice = Console.ReadLine();

        //obsługa wyboru użytkownika
        switch(choice)
        {
          case "1":
            //wyczyszczenie listy zwierząt
            animals.Clear();

            //wyświetlenie potwierdzenia
            if (animals.Count == 0)
            {
              Console.WriteLine("\nUsunięto wszystkie zwierzęta\n");
            }
            break;
          case "2":
            //wyświetlenie listy zwierząt z numerami
            for (int i = 0; i < animals.Count; i++)
            {
              Console.WriteLine((i + 1) + ". " + animals[i].Name);
            }
            Console.Write("\nPodaj numer zwierzęcia, które chcesz usunąć:");

            //wczytanie numeru zwierzęcia od użytkownika
            int index = int.Parse(Console.ReadLine()) - 1;

            //sprawdzenie czy numer jest poprawny
            if (index >= 0 && index < animals.Count)
            {
              //usunięcie zwierzęcia z listy
              animals.RemoveAt(index);
              Console.WriteLine("\nUsunięto zwierzę\n");
            }
            else
            {
              Console.WriteLine("Niepoprawny numer. Spróbuj ponownie");
            }
            break;
            default:
            Console.WriteLine("\nNiepoprawna opcja. Spróbuj ponownie");
            break;
        }
      }
      //wyświetlenie menu powrotu do menu głównego
      Console.WriteLine("\nWciśnij dowolny klawisz, aby wrócić do menu głównego");
      Console.ReadKey();
      ShowMainMenu(animals);
    }

    //metoda pokazująca szczegóły zwierzęcia
    private static void ShowAnimalDetails(List<Animal> animals)
    {
      Console.Clear();

      //sprawdzenie czy lista jest pusta
      if (animals.Count == 0)
      {
        Console.WriteLine("Nie ma żadnych zwierząt na liście");
      }
      else
      {
        //wyświetlenie listy zwierząt z numerami
        for (int i = 0; i < animals.Count; i++)
        {
          Console.WriteLine((i + 1) + ". " + animals[i].Name);
        }

        //zapytanie użytkownika o numer zwierzęcia
        Console.Write("\nPodaj numer zwierzęcia, którego szczegóły chcesz zobaczyć:");

        //wczytanie numeru zwierzęcia od użytkownika
        int index = int.Parse(Console.ReadLine()) - 1;

        //sprawdzenie czy numer jest poprawny
        if (index >= 0 && index < animals.Count)
        {
          //wyświetlenie szczegółów wybranego zwierzęcia
          Animal animal = animals[index];
          Console.WriteLine("Szczegóły zwierzęcia:");
          //Console.WriteLine(animal.Describe());
          Console.WriteLine("Nazwa: " + animal.Name);
          Console.WriteLine("Data urodzenia: " + animal.BirthDate.ToShortDateString());
          Console.WriteLine("Czy jest ssakiem: " + (animal.IsMammal ? "tak" : "nie"));
          Console.WriteLine("Rodzaj: " + animal.Kind);
          animal.ShowAge();
        }
        else
        {
          //wyświetlenie komunikatu o błędzie
          Console.WriteLine("Niepoprawny numer. Spróbuj ponownie");
        }
      }
      Console.WriteLine("\nWciśnij dowolny klawisz, aby wrócić do menu głównego\n");
      Console.ReadKey();
      ShowMainMenu(animals);
    }

    //metoda pokazująca listę zwierząt
    private static void ShowAnimalList(List<Animal> animals)
    {
      Console.Clear();

      //sprawdzenie czy lista jest pusta
      if (animals.Count == 0)
      {
        //wyświetlenie komunikatu o braku zwierząt
        Console.WriteLine("Nie ma żadnych zwierząt na liście");
      }
      else
      {
        //wyświetlenie nagłówka listy
        Console.WriteLine("Lista zwierząt:");

        //wyświetlenie nazw zwierząt z numerami
        for (int i = 0; i < animals.Count; i++)
        {
          Console.WriteLine((i + 1) + ". " + animals[i].Name);
        }
      }
      //wyświetlenie opcji powrotu do menu głównego
      Console.WriteLine("\nWciśnij dowolny klawisz, aby wrócić do menu głównego\n");
      Console.ReadKey();
      ShowMainMenu(animals);
    }

    //metoda dodająca nowe zwierzę
    private static void AddNewAnimal(List<Animal> animals)
    {
      //wyczyszczenie konsoli
      Console.Clear();

      //wszytanie danych o zwierzęciu od użytkownika
      Console.Write("Podaj nazwę zwierzęcia:");
      string name = Console.ReadLine();
      Console.Write("Podaj datę urodzenia zwierzęcia (w formacie RRRR-MM-DD):");
      DateTime birthDate = DateTime.Parse(Console.ReadLine());
      Console.Write("Czy zwierzę jest ssakiem? (tak/nie):");
      bool isMammal = Console.ReadLine().ToLower() == "tak"; //true/false
      Console.Write("Podaj rodzaj zwierzęcia (Ptak, Ryba, Gad, Płaz, Ssak):");
      Kind kind = (Kind)Enum.Parse(typeof(Kind), Console.ReadLine());

      //utworzenie obiektu klasy Animal z podanymi danymi
      Animal animal = new Animal(name, birthDate, isMammal, kind);

      //dodanie obiektu do listy zwierząt
      animals.Add(animal);

      //Wyświetlenie potwierdzenia
      Console.WriteLine("\nDodano nowe zwierzę: " + animal.Name);
      Console.WriteLine("Wciśnij dowolny klawisz, aby wrócić do menu głównego\n");
      Console.ReadKey();
      ShowMainMenu(animals);
    }
  }
}

/*
 * Zadanie: Napisz program w języku C#, który będzie umożliwiał zarządzanie listą zwierząt. Program powinien spełniać następujące wymagania.

Każde zwierzę powinno mieć następujące właściwości: nazwę, datę urodzenia, informację czy jest ssakiem i rodzaj (ptak, ryba, gad, płaz lub ssak).
Program powinien umożliwiać dodawanie nowych zwierząt do listy, podając ich właściwości od użytkownika.
Program powinien umożliwiać wyświetlanie listy zwierząt z ich numerami i nazwami.
Program powinien umożliwiać wyświetlanie szczegółów o wybranym zwierzęciu, takich jak opis, wiek i rodzaj.
Program powinien umożliwiać usuwanie wszystkich lub pojedynczego zwierzęcia z listy.
Program powinien mieć menu główne z opcjami do wyboru przez użytkownika.
Program powinien być napisany zgodnie z konwencją nazewnictwa i formatowania kodu w C#.
Wskazówki:

Użyj klasy Animal do reprezentowania zwierzęcia i zdefiniuj jej właściwości, konstruktory i metody.
Użyj typu wyliczeniowego Kind do reprezentowania rodzaju zwierzęcia i zdefiniuj jego wartości.
Użyj listy generycznej List<Animal> do przechowywania zwierząt i korzystaj z jej metod do dodawania, usuwania i wyświetlania elementów.
Użyj klasy Console i jej metod do komunikacji z użytkownikiem i obsługi wejścia i wyjścia.
Użyj instrukcji switch lub if do obsługi różnych opcji menu i wywoływania odpowiednich metod.
Użyj klasy DateTime i jej metod do przechowywania i obliczania daty urodzenia i wieku zwierzęcia.
*/



/*
 * wielokrotnie powtarzamy kod:
//wyświetlenie listy zwierząt z numerami
        for (int i = 0; i < animals.Count; i++)
        {
          Console.WriteLine((i + 1) + ". " + animals[i].Name);
        }
zmodyfikuj powyższy kod i dodaj nową metodę o nazwie DisplayAnimals, która będzie statyczna typu void
*/