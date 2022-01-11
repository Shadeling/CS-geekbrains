
using System.Text;
using System;
using System.Collections.Generic;

static class Message{
    
    static public void OnlyNWords(string str, int n){
        foreach(string word in str.Split(' ')){
            if(word.Length<=n){
                Console.Write(word+' ');
            }
        }
        Console.Write("\n");
    }

    static public string DeleteOnSymbolLast(string str, char c){
        string new_str = string.Empty;
        foreach(string word in str.Split(' ')){
            if(word[word.Length-1]!=c){
                new_str+=word;
                new_str+=' ';
            }
        }
        return new_str;
    }

    static public string LongestWord(string str){
        string max = string.Empty;
        int max_len = 0;
        foreach(string word in str.Split(' ')){
            if(word.Length>max_len){
                max = word;
                max_len = word.Length;
            }
        }
        return max;
    }

    static public string MaxConcatenate(string str){
        StringBuilder max = new StringBuilder();
        int max_len = 0;
        foreach(string word in str.Split(' ')){
            if(word.Length>=max_len){
                if(word.Length == max_len){
                    max.Append(' '+word);
                }
                else{
                    max.Clear();
                    max.Append(word);
                    max_len = word.Length;
                }
            }
        }
        return max.ToString();
    }

    static public Dictionary<string, int> StaticAnalisys(string str){
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach(string word in str.Split(' ')){
            if(dict.ContainsKey(word)){
                dict[word]+=1;
            }
            else{
                dict.Add(word, 1);
            }
        }
        return dict;
    }
}