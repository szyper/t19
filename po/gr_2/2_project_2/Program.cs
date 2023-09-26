using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_project_2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //komentarz w jednej linii

      /*
       * komentarz w 
       * wielu liniach
      */

      Console.Write("Pierwszy program ");
      Console.WriteLine("w języku C#");
      Console.WriteLine("test");
      Console.Clear();

      // typy danych
      /*
       * int 16, 32, 64
       * byte 0 - 255 (8 bitów => 1 bajt)
       * sbyte -128 - 127
       * short -32768 - 32767
       * int -2 147 483 648 - 2 147 483 647 
      */

      int i; // deklaracja zmiennej i
      int i1 = 10; //deklaracja z jednoczesną inicjalizacją zmiennej i 

      Console.WriteLine("Zmienna i1 wynosi: " + i1);

      System.Int32 i2 = 100;

      Console.WriteLine("Zmienna i1 wynosi: {0}, zmienna i2 wynosi: {1}", i1, i2);
      Console.WriteLine($"Zmienna i1 wynosi: {i1}, zmienna i2 wynosi: {i2}");

      byte b = 100;
      sbyte sb = -10;
      short s = -20000;

      //dokończyć uint i pozostałe typy danych

      Console.ReadKey();
    }
  }
}
