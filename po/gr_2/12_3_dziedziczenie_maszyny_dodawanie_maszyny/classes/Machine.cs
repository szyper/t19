using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_dziedziczenie_maszyny.classes
{
  public enum MachineType
  {
    Excavator,
    Crane,
    Bulldozer,
    Loader
  }
  internal class Machine
  {
    public string Name { get; set; }
    public MachineType Type { get; set; }

    //konsturktor główny
    public Machine(string name, MachineType type)
    {
      Name = name;
      Type = type;
      Console.WriteLine($"{Name} została stworzona");
    }

    //konstruktor kopiujący
    public Machine(Machine machine)
    {
      Name = machine.Name;
      Console.WriteLine($"Kopia maszyny {Name} została stworzona");
    }

    //destruktor
    ~Machine() 
    {
      Console.WriteLine($"{Name} została zniszczona");
    }

    public virtual void Start()
    {
      Console.WriteLine($"{Name} została uruchomiona" );
    }

    public void Stop()
    {
      Console.WriteLine($"{Name} została zatrzymana");
    }

    public virtual void Work()
    {
      Console.WriteLine($"{Name} pracuje");
    }
  }


}
