using System.Collections.Generic;

class Arr{
    private int[] mass;
    public int sum;
    public Dictionary<int, int> dict= new Dictionary<int, int>();
    public Arr(int size, int start, int step){
        mass = new int[size];
        int elem = start;
        for(int i=0; i<size; i+=1){
            mass[i] = elem;
            elem+=step;
        }
        FillDict();
    }

    public Arr(int size, int number){
        mass = new int[size];
        for(int i=0; i<size; i+=1){
            mass[i] = number;
        }
        FillDict();
    }

    private void FillDict(){
        dict= new Dictionary<int, int>();
        for(int i=0; i<mass.Length; i+=1){
            if(dict.ContainsKey(mass[i])){
                dict[mass[i]]+=1;
            }
            else{
                dict.Add(mass[i], 1);
            }
        }
    }
    private void CalcSum(){
        sum=0;
        for(int i=0; i<mass.Length; i++){
            sum+=mass[i];
        }
    }

    public string ToString(){
        string res=string.Empty;
        for(int i=0; i<mass.Length; i+=1){
            res+=mass[i].ToString()+' ';
        }
        return res;
    }
    public int[] Inverse(){
        int[] new_mass = new int[mass.Length];
        for(int i=0; i<mass.Length; i++){
            new_mass[i]*=-1*mass[i];
        }
        return new_mass;
    }

    public Arr Multi(int a){
        for(int i=0; i<mass.Length; i++){
            mass[i]*=a;
        }
        CalcSum();
        return this;
    }
    public int MaxCount(){
        int max = mass[0];
        int count = 1;
        for(int i=1; i<mass.Length; i++){
            if(mass[i]>max){
                count = 1;
                max = mass[i];
            }
            else if(mass[i]==max){
                count++;
            }
        }
        return count;
    }
}