using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_dziedziczenie_maszyny.classes
{
  internal class Excavator : Machine
  {
    //konstruktor łańcuchowy
    public Excavator(string name, MachineType type) : base(name, type)
    {
    }

    //konstuktor kopiujący
    public Excavator(Excavator excavator) : base(excavator)
    {

    }

    //destruktor
    ~Excavator()
    {
      Console.WriteLine($"Koparka {Name} została zniszczona");
    }

    //przesłonięcie metody wirtualnej Start
    public override void Start()
    {
      base.Start();
      Console.WriteLine($"{Name} rozpoczyna kopanie");
    }

    //przeciążenie metody Stop
    public void Stop(string reason)
    {
      Console.Write($"{Name} została zatrzymana z powodu: ");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write($"{reason}");
      Console.ResetColor();
    }

    //metoda symulująca kopanie
    public void Dig()
    {
      Console.WriteLine($"{Name} kopie");
    }

    //przesłonięcie metody Work
    public override void Work()
    {
      Dig();
    }
  }
}
