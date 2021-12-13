// 1. Написать метод, возвращающий минимальное из трёх чисел.
// Миронов Святослав

double min(double a, double b, double c){
    if(a<b){
        if(a<c) return a;
        else return c;
    }
    else{
        if(b<c) return b;
        else return c;
    }
}

double a=1,b=2,c=3;
Console.Write(min(a,b,c));