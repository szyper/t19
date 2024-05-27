using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_dziedziczenie_maszyny.classes
{
  internal class Crane : Machine
  {
    public Crane(string name, MachineType type) : base(name, type)
    {
    }

    public Crane(Crane crane) : base(crane)
    {

    }

    ~Crane()
    {
      Console.WriteLine($"Dźwig {Name} został zniszczony");
    }

    public override void Start()
    {
      base.Start();
      Console.WriteLine($"{Name} rozpoczyna podnoszenie ładunku");
    }

    //metoda symulująca podnoszenie ładunku
    public void Lift()
    {
      Console.WriteLine($"{Name} podnosi ładunek");
    }

    public override void Work()
    {
      Lift();
    }
  }
}
