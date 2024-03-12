using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3_konstruktory.classes
{
  //definicja typu enum Kind
  enum Kind
  {
    Ptak,
    Ryba,
    Gad,
    Płaz,
    Ssak
  }
  internal class Animal
  {
    //właściwości
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsMammal { get; set; }
    public Kind Kind { get; set; }

    public Animal(string name)
    {
      Name = name;
      BirthDate = DateTime.MinValue; //domyślna data urodzenia
      IsMammal = true; //ustawienie domyślnej warości
      Kind = Kind.Ssak; //ustawienie domyślnego rodzaju
    }

    public Animal(string name, DateTime birthDate) :this(name)
    {
      BirthDate = birthDate;
    }

    public Animal(string name, DateTime birthDate, bool isMammal) : this(name, birthDate)
    {
      IsMammal = isMammal;
    }

    public Animal(string name, DateTime birthDate, bool isMammal, Kind kind) : this(name, birthDate, isMammal)
    {
      Kind = kind;
    }

    //metoda opisująca zwierzę
    public string Describe()
    {
      string description = "Nazwa zwierzęcia " + Name + ".Data urodzenia: " + BirthDate.ToShortDateString() + "r. ";
      if (IsMammal)
      {
        description += "Zwierzę jest ssakiem. ";
      }
      else
      {
        description += "Zwierzę nie jest ssakiem ";
      }

      description += "Rodzaj zwierzęcia: " + Kind;
      return description;
    }

    public void ShowAge()
    {
      //obliczenie wieku zwierzęcia w latach
      int age = DateTime.Now.Year - BirthDate.Year;

      Console.WriteLine($"Wiek {Name} wynosi: {age} lata");
    }
  }
}
