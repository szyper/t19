using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_dziedziczenie
{
  internal class Program
  {
    //typ wyliczeniowy dla rodzajów paliwa
    public enum FuelType
    {
      Petrol, //benzyna
      Diesel, //olej napędowy
      Electric //elektryczny
    }
    public class Vehicle
    {
      public string Brand { get; set; }
      public string Model { get; set; }
      public double Fuel { get; private set; } //poziom paliwa
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
        Console.WriteLine("\nZatankowano {amount} litrów paliwa w pojeździe");
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
        Console.WriteLine("\nSilnik samochodu uruchomiony"); //przesłanianie metody bazowej
      }

      public override void StopEngine()
      {
        Console.WriteLine("\nSilnik samochodu zatrzymany");
      }

      //metoda do zmiany biegów
      public void ChangeGear(sbyte gear)
      {
        if (!IsAutomatic)
        {
          if (gear < 0 || gear > MaxGear)
          {
            Console.WriteLine("\nNieprawidłowy bieg");
          }
          else
          {
            CurrentGear = gear;
            Console.WriteLine("\nZmiana biegu na {gear}");
          }
        }
        else
        {
          Console.WriteLine("\nTen samochód ma automatyczną skrzynię biegów");
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
          else if (speed > 20 && speed < 40)
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
    static void Main(string[] args)
    {

      Vehicle v = new Vehicle();
      v.Brand = "Lamborghini";
      Console.WriteLine(v.Brand);
      v.StartEngine();

      Car car = new Car();
      car.Brand = "Fiat";
      Console.WriteLine($"\n\ncar.Brand");
      car.StartEngine();
      car.NumberOfDoors = 4;

      //Car car1 = new Car { Brand = "Toyota", Model = "Supra", NumberOfDoors = 4, FuelType = FuelType.Petrol };
      Car car1 = new Car { Brand = "Toyota", Model = "Supra", NumberOfDoors = 4, FuelType = FuelType.Petrol, MaxGear = 5, IsAutomatic = false };




      Console.ReadKey();
    }
  }
}