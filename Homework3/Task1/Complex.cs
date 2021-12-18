class Complex
    {
        public double im;
        public double re;
        //  в C# в структурах могут храниться также действия над данными
        public Complex(double imag, double real){
            im = imag;
            re = real;
        }
        public Complex(){
            im = 0;
            re = 0;
        }

        public Complex Plus(Complex x)
        {
            Complex y = new Complex();;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y = new Complex();;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y = new Complex();;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }