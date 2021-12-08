// See https://aka.ms/new-console-template for more information
double wei, hei, IMT;
Console.Write("Введите рост: ");
string str = Console.ReadLine();
wei = Convert.ToDouble(str);
Console.Write("Введите вес: ");
str = Console.ReadLine();
hei = Convert.ToDouble(str);

IMT = wei/(hei*hei);
Console.Write("Индекс массы тела: {0}",IMT);
