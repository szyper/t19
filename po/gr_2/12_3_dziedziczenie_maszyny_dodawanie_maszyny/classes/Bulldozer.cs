using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_dziedziczenie_maszyny.classes
{
  internal class Bulldozer : Machine
  {
    public Bulldozer(string name, MachineType type) : base(name, type)
    {
    }

    public Bulldozer(Bulldozer bulldozer) : base(bulldozer)
    {

    }

    ~Bulldozer()
    {
      Console.WriteLine($"Spychacz {Name} został zniszczony");
    }

    public override void Start()
    {
      base.Start();
      Console.WriteLine($"{Name} rozpoczyna równanie terenu");
    }

    //symulacja równania terenu
    public void Flatten()
    {
      Console.WriteLine($"{Name} równa teren");
    }

    public override void Work()
    {
      Flatten();
    }
  }
}
