//а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
//Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.

//Миронов С.В.
using System;

int readInt(string text){
    bool flag;
    int ret;
    do{
        Console.Write(text);
        flag = int.TryParse(Console.ReadLine(),out ret);
    }while(!flag);
    
    return ret;
}


int sum = 0, num; 

do{
    num = readInt("Введите число: ");
    if(num%2==1 && num>0) sum+=num;
}while(num!=0);

Console.WriteLine($"Сумма нечетных >0  = {sum}");