using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_klasy.classes
{
  internal class Teacher
  {
    public List<string> Subjects { private get; set; }

    public string GetSubjects()
    {
      return string.Join(", ", Subjects);
    }
  }
}
