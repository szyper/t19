using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_klasy
{
    internal class Program
    {
        class Person
        {
            public string Surname { get; set; }
            public string LastName { get; set; }
            public float Height { get; set; }
            public float Weight { get; set; }
            static void Main(string[] args)
            {
                Person nowak = new Person();
            }
        }
    }
}
