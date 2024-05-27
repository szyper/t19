using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_dziedziczenie_maszyny.classes
{
  //klasa zarządzająca grupą maszyn
  internal class MachineSimulator
  {
    private List<Machine> machines = new List<Machine>();

    //metoda dodająca maszynę do symulatora
    public void AddMachine(Machine machine)
    {
      machines.Add(machine);
    }

    //metoda uruchamiająca wszystkie maszyny
    public void StartAll()
    {
      foreach (var machine in machines)
      {
        machine.Start();
      }
    }

    //metoda symulująca pracę wszystkich maszyn
    public void WorkAll()
    {
      foreach (var machine in machines)
      {
        machine.Work();
      }
    }

    //metoda zatrzymująca wszystkie maszyny
    public void StopAll()
    {
      foreach (var machine in machines)
      {
        machine?.Stop();
      }
    }

    //metoda wyświetlająca wszystkie maszyny
    public void DisplayAllMachines()
    {
      Console.WriteLine("Lista dostępnych maszyn:");
      foreach (var machine in machines)
      {
        Console.WriteLine($" - {machine.Name}");
      }
    }
  }
}
