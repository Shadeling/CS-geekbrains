//3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.

//Миронов С.В.
using System;
using System.Collections.Generic;

Dictionary<char, int> createDict(string str){
    Dictionary<char, int> dict = new Dictionary<char, int>();
    foreach(char c in str){
        if(dict.ContainsKey(c)){
            dict[c]+=1;
        }
        else{
            dict.Add(c, 1);
        }
    }
    return dict;
}


//Первое что пришло в голову после предыдущей задачи с Dict, поэтому так :)
bool TestPermutation(string a, string b){
    Dictionary<char, int> first = createDict(a);
    Dictionary<char, int> second = createDict(b);
    if(first.Count == second.Count && !first.Except(second).Any()) return true;
    return false;
}

string str1="badc" , str2 ="abcd";
Console.WriteLine(TestPermutation(str1,str2));
str2 ="abcda";
Console.WriteLine(TestPermutation(str1,str2));