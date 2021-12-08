// See https://aka.ms/new-console-template for more information
string name, surname, age;
Console.Write("Введите свое имя: ");
name = Console.ReadLine();
Console.Write("Введите фамилию: ");
surname = Console.ReadLine();
Console.Write("Введите Возраст: ");
age = Console.ReadLine();

Console.WriteLine("\n"+name+' '+surname+' '+age);
Console.WriteLine("\n{0} {1} {2}",name,surname,age);
Console.WriteLine($"\n{name} {surname} {age}");