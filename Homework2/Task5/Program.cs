// 5.а) Написать программу, которая запрашивает массу и рост человека, 
//вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

//Миронов Святослав

double wei, hei, IMT;
Console.Write("Введите рост в сантиметрах: ");
string str = Console.ReadLine();
hei = Convert.ToDouble(str)/100;
Console.Write("Введите вес: ");
str = Console.ReadLine();
wei = Convert.ToDouble(str);
double x_wei=0;

IMT = wei/(hei*hei);

//IMT = (wei-x)/(hei*hei)
if(IMT<18){
    x_wei = 18*hei*hei-wei;
    Console.Write($"Вам нужно набрать {x_wei} кг");
}
else if(IMT<25){
    Console.Write("Вы в норме");
}
else{
    x_wei = -(25*hei*hei-wei);
    Console.Write($"Вам нужно похудеть на {x_wei} кг");
}

