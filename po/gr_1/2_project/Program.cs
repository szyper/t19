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

      byte b = 255; //0 - 255
      sbyte sb = -128; //-128 - 127

      short s = -30000; //-32768 - 32767

      int i1 = 1000000; //-2 147 483 648 - 2 147 483 647  

      /*
       * byte 0-255 (8 bitów => 1 bajt)
       * sbyte -128-127 (8 bitów => 1 bajt)
       * short -32768-32767 (16 bitów => 2 bajt)
       * ushort 0-65535 (16 bitów => 2 bajt)
       * int -2 147 483 648 - 2 147 483 647 (32 bity => 4 bajty)
       * uint 0 - 4 294 967 295 (32 bity => 4 bajty)
       * long -9 223 372 036 854 775 808 - 9 223 372 036 854 775 807 (64 bity => 8 bajtów)  sufix L
       * ulong 0 - 18 446 744 073 709 551 615 (64 bity => 8 bajtów) sufix UL
       * 
       * bool (true lub false) ()
       * char U+0000 do U+FFFF (16 bitów => 2 bajty, znak z tablicy Unicode)
       * string ?
       * 
       * float -3.4 x 10^38 do 3.4 x 10^38 (32 bity) sufiks F
       * double (64 bity)
       * decimal (128 bitów)
       * 
       */

      long l = -20L;
      ulong ul = 20UL;
      Console.WriteLine("Zmienna l: {0}, zmienna ul: {1}", l, ul);

      float f = 10.5F;
      Console.WriteLine(f); //10,5

      float f1 = 10;
      Console.WriteLine(f1); //10

      Console.WriteLine("Ilość batów w pamięci typu float: " + sizeof(float)); //4 bajty
      Console.WriteLine("Ilość batów w pamięci typu bool: " + sizeof(bool)); //1 bajt
      Console.WriteLine("Ilość batów w pamięci typu int: " + sizeof(int)); //4 bajty

      //zapis systemów liczbowych
      //binarny
      Console.WriteLine(0b1010); //10

      //oktalny
      Console.WriteLine(011);
      int i2 = Convert.ToInt32("12", 8);
      Console.WriteLine("Zamiana liczby oktalnej na dziesiętną: " + i); //12(8) => 1x8^1+2x8^0

      //heksadecymalny
      Console.WriteLine(0xA); //10

      //zakres typów danych
      Console.WriteLine(byte.MinValue); //0
      Console.WriteLine(byte.MaxValue); //255

      Console.WriteLine(sbyte.MinValue); //-128
      Console.WriteLine(sbyte.MaxValue); //127

      Console.WriteLine(int.MinValue); //-2 147 483 648
      Console.WriteLine(Int32.MinValue); //-2 147 483 648
      Console.WriteLine(System.Int32.MinValue); //-2 147 483 648

      Console.WriteLine(long.MinValue); //-9223372036854775808
      Console.WriteLine(long.MaxValue); //9223372036854775807

      //Unicode
      Console.OutputEncoding = System.Text.Encoding.Unicode;
      Console.WriteLine("♥");
      Console.WriteLine("\x2665");

      char letter = 'a';
      Console.WriteLine(letter); //a

      char letter2 = (char)97;
      Console.WriteLine(letter2); //a

      Console.ReadKey();
    }
  }
}
