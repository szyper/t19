using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_konstruktory.classes
{
  internal class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }


  }
}
