//1. Создать программу, которая будет проверять корректность ввода логина. 
//Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:

//Миронов С.В.

using System.Text.RegularExpressions;
using System;


Regex r = new Regex(@"[a-zA-Z]+[a-zA-Z0-9]{1,9}");
string str = string.Empty;
do{
    Console.Write("Введите логин: ");
    str = Console.ReadLine();

    if(r.IsMatch(str)){
        Console.WriteLine("Логин подходит");
    }
    else{
        Console.WriteLine("Логин не подходит");
    }
}while(str!="");
