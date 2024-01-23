using _9_1_klasy.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_klasy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person nowak = new Person();
      //nowak.Surname = "Nowak";
      nowak.SetSurname("Pawlak");
      Console.WriteLine("Nazwisko: " + nowak.FirstName);

      Student s1 = new Student();
      s1.StudentNumber = "12345";
      Console.WriteLine("Numer indeksu studenta: " + s1.StudentNumber);

      Teacher t1 = new Teacher();
      t1.Subjects = new List<string>() { "matematyka", "infomatyka" };

      //foreach (var subject in t1.Subjects)
      //{
      //  Console.WriteLine(subject);
      //}

      //Console.WriteLine(string.Join(", ", t1.Subjects));

      Console.WriteLine(t1.GetSubjects());

      nowak.Address = new Address();
      nowak.Address.City = "Poznań";
      nowak.Address.Street = "Polna";
      nowak.Address.HouseNumber = "1b/2";
      nowak.Address.PostalCode = "12-345";

      Console.WriteLine("Adres: " + nowak.Address.GetAddress());

      nowak.DateOfBirth = DateTime.Now;
      Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth); //Data urodzenia: 23.01.2024 09:24:05

      nowak.DateOfBirth = new DateTime();
      Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth); //Data urodzenia: 01.01.0001 00:00:00

      nowak.DateOfBirth = new DateTime(2000-2-14);
      Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth); //Data urodzenia: 01.01.0001 00:00:00

      nowak.DateOfBirth = new DateTime(2000,2, 14);
      Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth); //Data urodzenia: Data urodzenia: 14.02.2000 00:00:00

      nowak.DateOfBirth = new DateTime(2000, 2, 14);
      Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth.ToShortDateString()); //Data urodzenia: 14.02.2000

      nowak.DateOfBirth = new DateTime(2000, 2, 14, 9, 29, 55);
      Console.WriteLine("Czas urodzenia: {0}", nowak.DateOfBirth.ToShortTimeString()); //Czas urodzenia: 09:29

      Console.WriteLine("Czas urodzenia: {0}", nowak.DateOfBirth.ToLongTimeString()); //Czas urodzenia: 09:29:55

      Console.WriteLine("Czas urodzenia: {0}", nowak.DateOfBirth.ToLongDateString()); //Czas urodzenia: poniedziałek, 14 lutego 2000

      Console.ReadKey();

    }

  }
}
