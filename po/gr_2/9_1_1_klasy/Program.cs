using _9_1_klasy.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_klasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person nowak = new Person();
            //nowak.FirstName = "Anna";
            nowak.SetFirstName("Paweł");
            Console.WriteLine("Imię: " + nowak.FirstName);
            nowak.LastName = "Nowak";
            //Console.WriteLine("Nazwisko: " + nowak.LastName);
            Console.WriteLine("Nazwisko: " + nowak.GetLastName());

            Student s1 = new Student();
            s1.StudentNumber = "12345";
            Console.WriteLine("Numer indeksu studenta: " + s1.StudentNumber);

            Teacher t1 = new Teacher();
            t1.Subjects = new List<string> { "matematyka", "informatyka", "historia" };

            //foreach (var subject in t1.Subjects)
            //{
            //  Console.WriteLine(subject);
            //}

            //Console.WriteLine(string.Join(", ", t1.Subjects));

            Console.WriteLine(t1.GetSubjects());

            nowak.Address = new Address();
            nowak.Address.City = "Poznań";
            nowak.Address.Street = "Polna";
            nowak.Address.HouseNumber = "1c/4";
            nowak.Address.PostalCode = "11-234";
            Console.WriteLine(nowak.Address.GetAddress());

            nowak.DateOfBirth = DateTime.Now;
            Console.WriteLine("Data i czas: {0}", nowak.DateOfBirth); //Data i czas: 23.01.2024 12:08:11

            nowak.DateOfBirth = new DateTime();
            Console.WriteLine("Data i czas: {0}", nowak.DateOfBirth); //Data i czas: 01.01.0001 00:00:00

            nowak.DateOfBirth = new DateTime(2000 - 3 - 29);
            Console.WriteLine("Data i czas: {0}", nowak.DateOfBirth); //Data i czas: 01.01.0001 00:00:00

            nowak.DateOfBirth = new DateTime(2000, 3, 29);
            Console.WriteLine("Data i czas: {0}", nowak.DateOfBirth); //Data i czas: 29.03.2000 00:00:00

            nowak.DateOfBirth = new DateTime(2000, 3, 29);
            Console.WriteLine("Data: {0}", nowak.DateOfBirth.ToShortDateString()); //Data: 29.03.2000

            nowak.DateOfBirth = new DateTime(2000, 3, 29);
            Console.WriteLine("Czas: {0}", nowak.DateOfBirth.ToShortTimeString()); //Czas: 00:00

            nowak.DateOfBirth = new DateTime(2000, 3, 29, 12, 13, 28);
            Console.WriteLine("Czas: {0}", nowak.DateOfBirth.ToShortTimeString()); //Czas: 12:13

            nowak.DateOfBirth = new DateTime(2000, 3, 29, 12, 13, 28);
            Console.WriteLine("Czas: {0}", nowak.DateOfBirth.ToLongTimeString()); //Czas: 12:13:28

            nowak.DateOfBirth = new DateTime(2000, 3, 29, 12, 13, 28);
            Console.WriteLine("Data i dzień tygodnia: {0}", nowak.DateOfBirth.ToLongDateString()); //Data i dzień tygodnia: środa, 29 marca 2000

            Console.Clear();
            Person p1 = new Person();
            p1.Gender = Gender.mężczyzna;
            Console.WriteLine(p1.Gender);

            p1.Permission = Permission.User;
            Console.WriteLine(p1.Permission);

            Console.ReadKey();
        }
    }
}