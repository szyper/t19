using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_dziedziczenie_maszyny.classes
{
  internal class MachineFactory
  {
    public static Machine CreateMachine(string type)
    {
      switch(type)
      {
        case "Koparka":
          return new Excavator("Nowa koparka", MachineType.Excavator);
        case "Dźwig":
          return new Crane("Nowy dźwig", MachineType.Crane);
        case "Spychacz":
          return new Bulldozer("Nowy spychacz", MachineType.Bulldozer);
        case "Ładowarka":
          return new Loader("Nowa ładowarka", MachineType.Loader);
        default:
          throw new ArgumentException("Nieznany typ maszyny");
      }
    }
  }
}
