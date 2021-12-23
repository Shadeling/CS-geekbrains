// Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
// Создайте структуру Account, содержащую Login и Password.

using System;
using System.IO;

bool check(string login, string pass){
    if(login=="root" && pass=="GeekBrains"){
        return true;
    }
    return false;
}


StreamReader sr = new StreamReader("file.txt");
string[] mass = new string[2];
mass[0] = sr.ReadLine();
mass[1] = sr.ReadLine();
Account acc;
acc.Login = mass[0]; acc.Pass = mass[1];
if(check(acc.Login, acc.Pass)){
    Console.Write("Вы в системе");
    System.Environment.Exit(0);
}
Console.Write("Неправильный пароль");
