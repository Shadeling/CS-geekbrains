// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
// Миронов Святослав
string str = Console.ReadLine();
int sum = 0;
while(str != "0"){
    if(Convert.ToInt32(str)%2==1 && Convert.ToInt32(str)>0){
        sum+=Convert.ToInt32(str);
    }
    str = Console.ReadLine();
}
Console.Write(sum);

