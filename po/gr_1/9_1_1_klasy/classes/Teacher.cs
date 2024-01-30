using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_1_klasy.classes
{
    internal class Teacher
    {
        public List<string> Subjects { get; set; }

        public void GetSubjects()
        {
            foreach (var subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
