
using System;
using System.IO;
using System.Collections.Generic;

public delegate double Fun(double x);
class Program{

    public static void SaveFunc(string fileName, double a,double b,double h, Fun function)
    {
        if(h!=0){
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x<=b)
            {
                bw.Write(function(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        else{
            Console.WriteLine("H не должно быть равно 0");
        }
    }

    public static double[] Load(string fileName, out double min)
    {
        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        BinaryReader bw = new BinaryReader(fs);
        min = double.MaxValue;
        double d;
        List<double> ret = new List<double>();
        for(int i=0;i<fs.Length/sizeof(double);i++)
        {
            // Считываем значение и переходим к следующему
            d = bw.ReadDouble();
            ret.Add(d);
            if (d < min) min = d;
        }
        bw.Close();
        fs.Close();
        return ret.ToArray();
    }

    static void Main(string[] args)
        {
            Fun[] mass= new Fun[3];
            mass[0]=delegate (double x){return x*x*x+10;};
            mass[1]=delegate (double x){return Math.Cos(x)*Math.Cos(x);};
            mass[2]=delegate (double x){return 1/Math.Log10(x);};
            string s = string.Empty;
            int choise;
            double a, b, h, min;

            do{
                Console.WriteLine("Выберите, на какой функции вы хотите найти минимум:");
                Console.WriteLine("0) Выйти из программы");
                Console.WriteLine("1) x*x*x+10");
                Console.WriteLine("2) Math.Cos(x)*Math.Cos(x)");
                Console.WriteLine("3) 1/Math.Log10(x)");
                Int32.TryParse(Console.ReadLine(), out choise);
                if(choise ==0){continue;}

                Console.WriteLine("Введите начало интервала для поиска(a)");
                Double.TryParse(Console.ReadLine(), out a);
                Console.WriteLine("Введите конец интервала для поиска(b)");
                Double.TryParse(Console.ReadLine(), out b);
                Console.WriteLine("Введите шаг поиска(h), в формате '0,01'");
                Double.TryParse(Console.ReadLine(), out h);

                Console.WriteLine($"{a}  {b}  {h}");
                SaveFunc("data.bin", a, b, h, mass[choise-1]);
                Load("data.bin", out min);
                Console.WriteLine($"Минимальное значение функции = {min}\n\n");
            }while(choise!=0);
        }


}
    
