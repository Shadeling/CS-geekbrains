// See https://aka.ms/new-console-template for more information
double Distance(double x1, double y1, double x2, double y2){
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
}

double x1, x2, y1, y2;
Console.Write("Введите x1: ");
string str = Console.ReadLine();
x1 = Convert.ToDouble(str);
Console.Write("Введите y1: ");
str = Console.ReadLine();
y1 = Convert.ToDouble(str);

Console.Write("Введите x2: ");
str = Console.ReadLine();
x2 = Convert.ToDouble(str);
Console.Write("Введите y2: ");
str = Console.ReadLine();
y2 = Convert.ToDouble(str);

Console.Write("\nРасстояние = {0:f2}", Distance(x1,y1,x2,y2));
