//3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
//Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
//Написать программу, демонстрирующую все разработанные элементы класса.
//Добавить свойства типа int для доступа к числителю и знаменателю;
//Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
// ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
// *** Добавить упрощение дробей.

using System;
    class Program
    {
        static int readInt(string text){
            bool flag;
            int ret;
            do{
                Console.Write(text);
                flag = int.TryParse(Console.ReadLine(),out ret);
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
            Console.WriteLine("4 - Деление чисел");
            Console.WriteLine("0 - Выйти из программы");
            do{
                flag = int.TryParse(Console.ReadLine(),out ret);
            }while(!flag);
            return ret;
        }
        static void Main(string[] args)
        {
            int ch1,ch2, zn1,zn2;
            int swit;
            ch1 = readInt("Введите числитель первого числа: ");
            zn1 = readInt("Введите знаменатель первого числа: ");
            Fractional first = new Fractional(ch1,zn1);
            ch2 = readInt("Введите числитель второго числа: ");
            zn2 = readInt("Введите знаменатель второго числа: ");
            Fractional second = new Fractional(ch2,zn2);
            
            do{
                swit = Dialog();
                Console.WriteLine($"\nПервое число {first.ToString()}");
                Console.WriteLine($"Второе число {second.ToString()}");
                switch(swit){
                    case 1: Console.WriteLine($"Сумма: {first.Plus(second).ToString()}"); break;
                    case 2: Console.WriteLine($"Разница: {first.Minus(second).ToString()}"); break;
                    case 3: Console.WriteLine($"Произведение: {first.Multi(second).ToString()}"); break;
                    case 4: Console.WriteLine($"Деление: {first.Divide(second).ToString()}"); break;
                }
            }while(swit!=0);
        }
    }