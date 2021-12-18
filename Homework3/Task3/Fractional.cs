class Fractional
    {
        public int chislitel;
        public int znamenatel;

        private double drob;
        //  в C# в структурах могут храниться также действия над данными
        public Fractional(int ch, int znam){
            chislitel = ch;
            if(znam!=0) znamenatel = znam;
            else{throw new ArgumentException("Знаменатель не может быть равен 0");}
            
            this.Simplify();
            drob = chislitel/znamenatel;
        }
        public Fractional(){
            chislitel = 0;
            znamenatel = 1; 
        }

        public double getDrob(){
            return drob;
        }

        public void Simplify(){
            for(int i=chislitel; i>1; i--){
                if(chislitel%i==0 && znamenatel%i==0){
                    chislitel/=i;
                    znamenatel/=i;
                }
            }
        }

        public Fractional Plus(Fractional x)
        {
            Fractional y = new  Fractional();;
            y.chislitel = chislitel*x.znamenatel + x.chislitel*znamenatel;
            y.znamenatel = znamenatel*x.znamenatel;
            y.Simplify();
            return y;
        }

        public Fractional Minus(Fractional x)
        {
            Fractional y = new Fractional();;
            y.chislitel = chislitel*x.znamenatel - x.chislitel*znamenatel;
            y.znamenatel = znamenatel*x.znamenatel;
            y.Simplify();
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Fractional Multi(Fractional x)
        {
            Fractional y = new Fractional();;
            y.chislitel = chislitel * x.chislitel;
            y.znamenatel = znamenatel*x.znamenatel;
            y.Simplify();
            return y;
        }

        public Fractional Divide(Fractional x)
        {
            Fractional y = new Fractional();;
            y.chislitel = chislitel * x.znamenatel;
            y.znamenatel = znamenatel*x.chislitel;
            y.Simplify();
            return y;
        }

        public string ToString()
        {
            return chislitel.ToString()+'/'+znamenatel.ToString();
        }
    }