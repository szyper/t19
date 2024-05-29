using _12_2_dziedziczenie_maszyny.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_dziedziczenie_maszyny
{
  internal class Program
  {
    static void Main(string[] args)
    {
      MachineSimulator simulator = new MachineSimulator();
      MachineTypeManager typeManager = new MachineTypeManager();
      MenuManager menuManager = new MenuManager();

      string userInput = "";

      do
      {
        menuManager.DisplayMenu();
        Console.Write("Wybierz opcję:");
        userInput = menuManager.GetUserInput();
        menuManager.ExecuteAction(userInput, simulator, typeManager);
      } while (userInput != "10");



























      /*Machine excavator = new Excavator("Excavator E-1000", MachineType.Excavator);
      excavator.Start();

      ((Excavator)excavator).Stop("awaria silnika\n");
      excavator.Stop();
      excavator.Work();

      Console.WriteLine("\n\n");

      MachineSimulator simulator = new MachineSimulator();

      //dodawanie maszyn do symulatora
      simulator.AddMachine(new Excavator("E-200", MachineType.Excavator));
      simulator.AddMachine(new Crane("C-200", MachineType.Crane));
      simulator.AddMachine(new Bulldozer("B-200", MachineType.Bulldozer));
      simulator.AddMachine(new Loader("L-200", MachineType.Loader));

      Console.WriteLine("\n\nNaciśnij przycisk, aby zakończyć program\n\n");
      */
      Console.ReadKey();
    }
  }
}
