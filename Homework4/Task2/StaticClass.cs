using System;
using System.IO;

static class StaticClass{
    public static int pairNum(int[] mass){
        int num = 0;
        for(int i=0; i<mass.Length-1; i++){
            if(mass[i]%3==0 && mass[i+1]%3!=0) num++;
        }
        return num;
    }

    public static int[] readArr(string file, int numbers){
        int[] array = new int[numbers];
        try{
            StreamReader sr = new StreamReader(file);

            for (int i = 0; i < numbers; i++)
            {
                int a = int.Parse(sr.ReadLine());
                array[i] = a;
            }
            sr.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка при чтении файла:");
            Console.WriteLine(e.Message);
        }

        return array;
    }


}