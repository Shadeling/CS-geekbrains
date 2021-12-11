// See https://aka.ms/new-console-template for more information
void Print(string str, int x, int y=0){
    for(var i=0; i<y; i++){
        Console.Write("\n");
    }
    for(var i=0; i<(int)(x-str.Length/2); i++){
        Console.Write(" ");
    }
    Console.Write(str);
}

string name="Svyatoslav", surname="Mironov", sity="Moscow";
string all = name+" "+surname+" "+sity;

Print(all, Console.WindowWidth/2, Console.WindowHeight/2);
