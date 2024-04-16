using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_destruktor_symulator.classes
{
  internal class Car
  {
    public string Brand { get; set; }
    public string Model { get; set; }
    public bool IsDamaged { get; set; }

    public Car(string brand, string model)
    {
      Brand = brand;
      Model = model;
      IsDamaged = false;
    }

    public void Drive()
    {
      if (!IsDamaged)
      {
        Console.WriteLine($"\nJadę samochodem {Brand} {Model}\n");
      }
      else
      {
        Console.WriteLine($"\nSamochód {Brand} {Model} ma awarię\n");
      }
    }

    public void SimulateRandomDamage()
    {
      Random random = new Random();

      int damageType = random.Next( 1, 4 ); //losuje liczby od 1 do 3

      switch ( damageType )
      {
        case 1:
          Console.WriteLine($"Samochód {Brand} {Model} ma przebitą oponę!");
          break;
        case 2:
          Console.WriteLine($"Silnik samochodu {Brand} {Model} jest uszkodzony!");
          break;
        case 3:
          Console.WriteLine($"Samochód {Brand} {Model} ma uszkodzone światło!");
          break;
      }

      IsDamaged = true;

    }

    ~Car()
    {
      Console.WriteLine($"Samochód {Brand} {Model} jest zezłomowany");
    }

  }
}
