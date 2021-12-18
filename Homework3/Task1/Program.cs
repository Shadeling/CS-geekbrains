// Миронов С.В.

using System;
    class Program
    {
        static double readDouble(string text){
            bool flag;
            double ret;
            do{
                Console.Write(text);
                flag = double.TryParse(Console.ReadLine(),out ret);
            }while(!flag);
            
            return ret;
        }

        static int Dialog(){
            bool flag;
            int ret;
            Console.WriteLine("Выберите что вы хотите сделать с числами:");
            Console.WriteLine("1 - Сумма чисел");
            Console.WriteLine("2 - Разность чисел");
            Console.WriteLine("3 - Произведение чисел");
            Console.WriteLine("0 - Выйти из программы");
            do{
                flag = int.TryParse(Console.ReadLine(),out ret);
            }while(!flag);
            return ret;
        }
        static void Main(string[] args)
        {
            double im1, im2, re1, re2;
            int swit;
            re1 = readDouble("Введите действительную часть первого числа: ");
            im1 = readDouble("Введите мнимую часть первого числа: ");
            re2 = readDouble("Введите действительную часть второго числа: ");
            im2 = readDouble("Введите мнимую часть второго числа: ");
            Complex first = new Complex(im1, re1);
            Complex second = new Complex(im2,re2);
            
            do{
                swit = Dialog();
                Console.WriteLine($"\nПервое число {first.ToString()}");
                Console.WriteLine($"Второе число {second.ToString()}");
                switch(swit){
                    case 1: Console.WriteLine($"Сумма: {first.Plus(second).ToString()}"); break;
                    case 2: Console.WriteLine($"Разница: {first.Minus(second).ToString()}"); break;
                    case 3: Console.WriteLine($"Произведение: {first. Multi(second).ToString()}"); break;
                }
            }while(swit!=0);
        }
    }

