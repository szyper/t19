using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_project
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //komentarz wjednej linii

      /* komentarz
       * w kilku liniach
       * w kilku liniach
       */

      Console.Write("C# - ");
      Console.WriteLine("język programowania");
      Console.WriteLine("Nowa linia");
      Console.Clear(); //czyszczenie ekranu

      //zmienne (deklaracja i inicjalizacja)
      int i = 10;
      Console.WriteLine("Wartość zmiennej i: " + i);


      Console.WriteLine("Wartość zmiennej i: {0}", i);

      System.Int64 j = 100;
      Console.WriteLine("Wartość zmiennej j: {0}, a wartość zmiennej i: {1}", j, i);

      //System.Int => 16, 32, 64

      long l = 20;
      Console.WriteLine("Zmienna l: {0}", l);

      byte b = 255; //0 - 255
      sbyte sb = -128; //-128 - 127

      short s = -30000; //-32768 - 32767

      int i1 = 1000000; //-2 147 483 648 - 2 147 483 647  

      //dokończyć typy m.in. uint

      Console.ReadKey();
    }
  }
}
