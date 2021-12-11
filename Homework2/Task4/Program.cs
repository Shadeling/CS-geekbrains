/*Реализовать метод проверки логина и пароля. 
На вход метода подается логин и пароль.
 На выходе истина, если прошел авторизацию, и ложь, если не прошел 
 (Логин: root, Password: GeekBrains). 
 Используя метод проверки логина и пароля, написать программу: 
 пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
С помощью цикла do while ограничить ввод пароля тремя попытками.*/

// Миронов Святослав
bool check(string login, string pass){
    if(login=="root" && pass=="GeekBrains"){
        return true;
    }
    return false;
}


int i=0;
do{
    Console.Write("Введите логин: ");
    string login = Console.ReadLine();
    Console.Write("Введите пароль: ");
    string pass = Console.ReadLine();
    if(check(login, pass)){
        Console.Write("Вы в системе");
        System.Environment.Exit(0);
    }
    i++;
}while(i<3);

Console.Write("Неправильный пароль трижды");
