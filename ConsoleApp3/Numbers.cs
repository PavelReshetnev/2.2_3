using System;
namespace ConsoleApp3;

public class Numbers
{
    public int num1;
    public int num2;
    

    public Numbers(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }
    

  
    public void Sum()
    {
        int sum = num1 + num2;
        Console.WriteLine($"Итоговая сумма равна {sum}\n");
        
    }

    public void Vivod() {
        Console.WriteLine($"Первое число: {this.num1} " + $"Второе число: {this.num2}\n");
        
    }

    public void Edit()
    {
        Console.WriteLine("Редактирование... Введите свои числа");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Изменено ...\n");
        

    }

    public void Max()
    {
        if (num1 > num2) {
            Console.WriteLine($"Максимальное число - {num1}\n");
        }else {
            Console.WriteLine($"Максимальное число - {num2}\n");
        }
        
    }
}