using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_klasy.classes
{
    enum Permission
    {
        Administrator = 1,
        Modifier = 2,
        User = 3,
        Guest = 4
    }
    enum Gender
    {
        mężczyzna,
        kobieta
    }
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public Address Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Permission Permission { get; set; }
        public void SetName(string name)
        {
            FirstName = name;
        }
        public void SetSurname(string surname)
        {
            LastName = surname;
        }
        public string GetData()
        {
            return $"\nImię i nazwisko: {FirstName} {LastName}, wzrost: {Height}cm, waga: {Weight}kg\n";
        }
    }
}
