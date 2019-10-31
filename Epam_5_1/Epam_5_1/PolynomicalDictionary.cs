using System;
using System.Collections.Generic;

namespace Epam_5_1
{
    class PolynomicalDictionary
    {

        //класс многочленов для работы от одной переменной и перегрузить сложение,вычитание,умножение --
        //определить свойства(степень многочлена и тд),индексатор на чтение и запись + 
        //перегрузить ТуСтринг,возвращающий строковое представление многочлена  + 
        /* 
         a = 5 + 2x;
         b = 3x^2 + 7x^3;
         a + b = 5 + 2x + 3x^2 + 7x^3
         a - b = a +(-b) = 5 + 2x - 3x^2 + 7x^3
         a*b = 15x^2 + 41x^3 + 14x^4 
         [a*b] = [0,0,15,41,14]
         */
        SortedDictionary<int, int> polynomDictionary;

        public PolynomicalDictionary()
        {
            polynomDictionary = new SortedDictionary<int, int>
            {
                { 0, 0 }
            };
        }
        public int this[int i]
            {
            get {
                if (i < 0)
                {
                    throw new ArgumentException("incorrect index!");
                }
                foreach (KeyValuePair<int, int> keyValue in polynomDictionary)
                {
                    if (i == keyValue.Key)
                    {
                        return keyValue.Value;
                    }
                }
                return 0;
            }
            set => polynomDictionary[i] = value;
        }
        public int Length
        {
            get
            {
                int a = 0;
                foreach (KeyValuePair<int, int> keyValue in polynomDictionary)
                {
                    if (keyValue.Value != 0)
                        a++;
                }
                return a;
            }
        }

        public static PolynomicalDictionary operator +(PolynomicalDictionary pol1, PolynomicalDictionary pol2)
        {
            if (pol1 == null | pol2 == null)
            {
                throw new ArgumentNullException("One of these polinoms are empthy");
            }
            PolynomicalDictionary res = new PolynomicalDictionary();
            int max = pol1.Length > pol2.Length ? pol1.Length : pol2.Length;
            for (int i = 0; i < max; i++)
            {
                if (pol1[i] == 0 && pol2[i] != 0)
                {
                    res[i] = pol2[i];
                    continue;
                }
                else if (pol2[i] == 0 && pol1[i] != 0)
                {
                    res[i] = pol1[i];
                    continue;
                }
                res[i] = pol1[i] + pol2[i];
            }
            return res;
        }
        public static PolynomicalDictionary operator -(PolynomicalDictionary pol1, PolynomicalDictionary pol2)
      {
            if (pol1 == null | pol2 == null)
            {
                throw new ArgumentNullException("One of these polinoms are empthy");
            }
            PolynomicalDictionary temp = new PolynomicalDictionary();
            foreach (KeyValuePair<int, int> keyValue in pol2.polynomDictionary)
            {
                temp[keyValue.Key] = -keyValue.Value;
            }
            return pol1 + temp;
      }

        public static PolynomicalDictionary operator *(PolynomicalDictionary pol1, PolynomicalDictionary pol2)
        {
            if (pol1 == null | pol2 == null)
            {
                throw new ArgumentNullException("One of these polinoms are empthy");
            }
            PolynomicalDictionary res = new PolynomicalDictionary();
            foreach (KeyValuePair<int,int> item in pol1.polynomDictionary)
            {
                foreach (KeyValuePair<int,int> item2 in pol2.polynomDictionary)
                {
                    if (item.Value!=0 && item2.Value!=0)
                    {
                        res[item.Key + item2.Key] += item.Value*item2.Value;
                    }
                }   
            }

            return res;
        }

    public override string ToString()
        {
            string temp = "";
            foreach (KeyValuePair<int, int> keyValue in polynomDictionary)
            {
                if (keyValue.Value == 0) continue;
                if (keyValue.Key != 0)
                    temp += "+";
                temp += $"{keyValue.Value}";
                if (keyValue.Key == 0) continue;
                else if (keyValue.Key == 1) temp += "x ";
                else if (keyValue.Key > 1) temp += "x^" + $"{keyValue.Key} ";
            }
            return temp;
        }
    }
}
