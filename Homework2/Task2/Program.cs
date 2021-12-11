// Написать метод подсчета количества цифр числа.
// Миронов Святослав
int digit_num(int a){
    int num = 0;
    while(a>0){
        num++;
        a/=10;
    }
    return num
}


int a = 2134;
Console.Write(digit_num(a));