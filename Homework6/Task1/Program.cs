
using System;

// Изменить программу вывода таблицы функции так, 
// чтобы можно было передавать функции типа double (double, double). 
// Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

//Миронов С.В.

public delegate double Fun(double x, double a);

class Program
{
    // Создаем метод, который принимает делегат
    // На практике этот метод сможет принимать любой метод
    // с такой же сигнатурой, как у делегата
    public static void Table(Fun F, double x, double b, double a)
    {
        Console.WriteLine("----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }
    // Создаем метод для передачи его в качестве параметра в Table
    public static double MyFunc1(double x, double a)
    {
        return a*x*x;
    }

    public static double MyFunc2(double x, double a)
    {
        return a*Math.Sin(x);
    }

    static void Main()
    {
        // Создаем новый делегат и передаем ссылку на него в метод Table
        Console.WriteLine("Таблица функции  a*x*x:"); 
        // Упрощение(c C# 2.0).Делегат создается автоматически.            
        Table(MyFunc1, -10, 10, 5); 
        Console.WriteLine("Таблица функции a*Math.Sin(x):");
        Table(MyFunc2, -10, 10, 5);      // Можно передавать уже созданные методы
    }
}

