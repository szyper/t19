using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_klasy.classes
{
 //   administartor, moderator, user, gość
    enum Permission
    {
        Administrator = 1,
        Moderator = 2,
        User = 3,
        Guest = 4
    } 
    enum Gender
    {
        kobieta,
        mężczyzna
    }
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { private get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public Address Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Permission Permission { get; set; }
        public void SetFirstName(string name)
        {
            FirstName = name;
        }

        public string GetLastName()
        {
            return LastName;
        }
    }
}