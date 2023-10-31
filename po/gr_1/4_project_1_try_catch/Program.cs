namespace _4_project_1_try_catch
{
  internal class Program
  {
    static void Main(string[] args)
    {
      bool isCorrect = false;
      do
      {
        try
        {
        
            Console.WriteLine("Podaj dwie liczby");
            Console.Write("Podaj x:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Podaj y:");
            int y = int.Parse(Console.ReadLine());
            Console.Write($"\nWynik dzielenia liczb ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{x} / {y} = {x / y}");
            Console.ResetColor();
            isCorrect = true;
        
        }
        catch (FormatException)
        {
          ErrorColorChange("Błędny format danych");
        }
        catch (OverflowException)
        {
          ErrorColorChange("Wartość podana przez użytkownika przekracza zakres liczby <{int.MinValue};{int.MaxValue}>");
        }
        catch (DivideByZeroException)
        {
          ErrorColorChange("Dzielenie przez 0");
        }
        catch (Exception ex)
        {
          ErrorColorChange("Błąd: {ex.Message}");

        }
        finally 
        {
          Console.WriteLine("\n\nDziękujemy za korzystanie z programu\n\n");
        }
      } while (!isCorrect);

    }

    static void ErrorColorChange(string comment)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"Błąd: {comment}");
      Console.ResetColor();
    }
  }
}