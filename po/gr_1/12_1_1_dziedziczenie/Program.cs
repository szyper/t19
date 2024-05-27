using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12_1_1_dziedziczenie
{
  //typ wyliczeniowy dla rodzajów paliwa
  public enum FuelType
  {
    Petrol, //Benzyna
    Diesel, //Olej napędowy
    Electric //Elektryczny
  }
  //klasa bazowa
  public class Vehicle
  {
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Fuel { get; set; } //poziom paliwa
    public FuelType FuelType { get; set; } //typ paliwa
    public ushort Speed { get; set; } //aktualna prędkość pojazdu

    public virtual void StartEngine()
    {
      Console.WriteLine("\nSilnik uruchomiony");
    }
    public virtual void StopEngine()
    {
      Console.WriteLine("\nSilnik zatrzymany");
    }
    public void Refuel(double amount)
    {
      Fuel += amount;
      Console.WriteLine($"\nZatankowano {amount} litrów paliwa w pojeździe\n");
    }
    public void UpdateSpeed(ushort newSpeed)
    {
      Speed = newSpeed;
    }
  }

  public class Car : Vehicle
  {
    public byte NumberOfDoors { get; set; } //liczba drzwi
    public int CurrentGear { get; private set; } //aktualny bieg
    public int MaxGear { get; set; } //maksymalny bieg
    public bool IsAutomatic { get; set; } //czy skrzynia jest automatyczna
    public override void StartEngine()
    {
      //base.StartEngine();
      Console.WriteLine("\nSilnik samochodu uruchomiony\n"); //przesłanianie metody bazowej
    }

    public override void StopEngine()
    {
      Console.WriteLine("\nSilnik samochodu zatrzymany\n");
    }

    //metoda do zmiany biegów
    public void ChangeGear(byte gear)
    {
      if (IsAutomatic)
      {
        Console.WriteLine("\nTen samochód ma automatyczną skrzynię biegów");
      }
      else
      {
        if (gear < 0 || gear > MaxGear)
        {
          Console.WriteLine("\nNieprawidłowy bieg");
        }
        else
        {
          CurrentGear = gear;
          Console.WriteLine($"\nZmiana biegu na {gear}");
        }
      }
    }

    private void AutomaticGearChange(int speed)
    {
      if (IsAutomatic)
      {
        if (speed < 20)
        {
          CurrentGear = 1;
        }
        else if (speed >= 20 && speed < 40)
        {
          CurrentGear = 2;
        }
        else
        {
          CurrentGear = 3;
        }
        Console.WriteLine($"\nAutomatyczna zmiana biegu na {CurrentGear} dla prędkości {speed} km/h");
      }
      else
      {
        Console.WriteLine("\nManualna skrzynia biegów");
      }
    }
  }

  public class ElectricCar : Car
  {
    public double BatteryCapacity { get; set; }
    public override void StartEngine()
    {
      //base.StartEngine();
      Console.WriteLine("\nWłączenie systemu elektrycznego");
    }
    public override void StopEngine()
    {
      Console.WriteLine("\nWyłączenie systemu elektrycznego");
    }

    public void ChargeBattery(double kWh)
    {
      if (kWh <= 0)
      {
        Console.WriteLine("\nNie można naładować baterii ujemną/zerową wartością");
      }
      else
      {
        AnimationHelper.ShowProgress("Ładowanie baterii:", " zakończone", 500, 10);
        BatteryCapacity += kWh;
        Console.WriteLine($"\n\nNaładowano baterię o {kWh} kWh");
      }
    }

    public class Truck : Vehicle
    {
      public double LoadCapacity { get; set; } //maksymalna nośność pojazdu
      public void LoadCargo(double weight)
      {
        if (weight <= 0)
        {
          Console.WriteLine("\nNie można załadować ujemnej wagi");
        }
        else if (weight > LoadCapacity)
        {
          Console.WriteLine($"Nie można załadować ładunku o wadze {weight} kg, ponieważ przekracza maksymalną nośność pojazdu wynoszącą {LoadCapacity} kg");
        }
        else
        {
          Console.WriteLine($"\nZaładowano ładunek o wadze {weight} kg");
        }
      }
    }
    public static class AnimationHelper
    {
      public static void ShowProgress(string prefix, string suffix, int delay, int totalSteps)
      {
        for (int i = 0; i <= totalSteps; i++)
        {
          Console.Write($"\r{prefix}[{new string('|', i)}{new string('.', totalSteps - i)}]{suffix} {i * (100 / totalSteps)}%");
          Thread.Sleep(delay);
        }
      }
    }
  }

  public class Truck : Vehicle
  {
    public double LoadCapacity { get; set; } //maksymalna nośność pojazdu
    public void LoadCargo(double weight)
    {
      if (weight <= 0)
      {
        Console.WriteLine("\nNie można załadować ujemnej wagi");
      }
      else if (weight > LoadCapacity)
      {
        Console.WriteLine($"Nie można załadować ładunku o wadze {weight} kg, ponieważ przekracza maksymalną nośność pojazdu wynoszącą {LoadCapacity} kg");
      }
      else
      {
        Console.WriteLine($"\nZaładowano ładunek o wadze {weight} kg");
      }
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      ElectricCar tesla = new ElectricCar
      {
        Brand = "Tesla",
        Model = "Model S",
        NumberOfDoors = 4,
        FuelType = FuelType.Electric,
        MaxGear = 1,
        IsAutomatic = true,
        BatteryCapacity = 95
      };

      tesla.StartEngine();
      tesla.StopEngine();
      tesla.ChargeBattery(2);
      Console.WriteLine(tesla.BatteryCapacity);

      Console.WriteLine();

      Truck volvo = new Truck
      {
        Brand = "Volvo",
        Model = "FH",
        Fuel = 300,
        FuelType = FuelType.Diesel,
        LoadCapacity = 25000
      };

      volvo.LoadCargo(5000);
      volvo.StartEngine();
      volvo.UpdateSpeed(80);
      volvo.StopEngine();


      Console.ReadKey();
    }
  }
}