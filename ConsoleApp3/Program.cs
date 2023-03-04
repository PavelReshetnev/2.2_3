using System;
namespace ConsoleApp3;

public class Program
{
    static void Main(string[] args)
    { Numbers chisla = new Numbers(63,71);
        
      Console.WriteLine("Вывод всех чисел - 1\nИзменить значения - 2\nСумма всех чисел - 3\nМаксимальное значение - 4\nВыход - 5");
      int a = Convert.ToInt32(Console.ReadLine());
      switch (a)
      {
          case 1 :
              chisla.Vivod();
              break;
          case 2:
              chisla.Vivod();
              chisla.Edit();
              chisla.Vivod();
              break;
          case 3 :
              chisla.Vivod();
              chisla.Sum();
              break;
          case 4 :
              chisla.Max();
              break;
          case 5:
              break;
      }
      
  }
        
}

