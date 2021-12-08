// See https://aka.ms/new-console-template for more information
double a=10, b=5;
Console.Write($"a = {a}, b = {b}");
a= b * a;
b= a/b;
a= a/b;
Console.Write($"\na = {a}, b = {b}");