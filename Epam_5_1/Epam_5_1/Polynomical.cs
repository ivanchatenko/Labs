using System;
using System.Linq;

namespace Epam_5_1
{
    class Polynomical
    {
        //класс многочленов для работы от одной переменной и перегрузить сложение,вычитание,умножение --
        //определить свойства(степень многочлена и тд),индексатор на чтение и запись + 
        //перегрузить ТуСтринг,возвращающий строковое представление многочлена  + 
        
        int[] polynomicalArr;
        public Polynomical(params int[] values)
        {
            polynomicalArr = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
                polynomicalArr[i] = values[i];
        }
        public int this[int i]
        {
            get => polynomicalArr[i];
            set => polynomicalArr[i] = value;
        }
        public int Length
        {
            get
            {
                int a = 0;
                foreach (int item in polynomicalArr)
                {
                    if(item != 0)
                        a++;
                }
                return a;
            } 
        }
        public static Polynomical operator +(Polynomical pol1,Polynomical pol2)
        {
            int max = pol1.Length > pol2.Length ? pol1.Length : pol2.Length;
            Polynomical res = new Polynomical(new int[max]);
            for (int i = 0; i < max; i++)
            {
                res[i] = pol1[i] + pol2[i];
            }
            return res;
        }
        public static Polynomical operator -(Polynomical pol1, Polynomical pol2)
        {
            Polynomical temp = ReversePolynomical(pol2);
            return pol1+temp;
        }
        public static Polynomical operator *(Polynomical pol1,Polynomical pol2)
        {
            int max = pol1.Length > pol2.Length ? pol1.Length : pol2.Length;
            Polynomical res = new Polynomical(new int[max]);
            for (int i = 0; i < max; i++)
            {
                res[i] = pol1[i]*pol2[i];
            }
            return res;
        }
        public static Polynomical ReversePolynomical(Polynomical pol)
        {
            for (int i = 0; i < pol.Length; i++)
            {
                pol[i] = -pol[i];
            }
            return pol;
        }
        public override string ToString()
        {
            string temp = $"{polynomicalArr[0]}";
            string sign;
            for (int i = 1; i < polynomicalArr.Length; i++)
            {
                if (polynomicalArr[i] == 0)
                    continue;
                sign = polynomicalArr[i] >= 0 ? "+" : "";
                temp += sign + polynomicalArr[i] + "x^" + i;
            }
            return temp;
        }
    }
}
