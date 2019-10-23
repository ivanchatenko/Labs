using System;

namespace Epam_3_2
{
    class Program
    {

        public static double RecursiveNegativeSub(int a1, int n, int step,int alim)
        {
            if (n == 1)
                return a1;
            double multi = 1;
            for (int i = 0; i < n; i++, a1 /= step)
            {
                if (a1 < alim) return multi;
                multi *=(double)a1 / step;
            }
            return multi;
        }

        //возвращает произведение Н элементов ариф.прогрессии чисел с первым элементом А1 и шагом Т(a(n) = a(n-1) + T)
        public static int RecursiveSum(int a1,int n,int step)
        {
            if (n == 0)
                return a1;

            int multi = 1;
            for (int i = 0; i <= n; i++, a1 += step)
            {
                multi *= (a1 + step);
            }

            return multi;
        }
        static void Main(string[] args)
        {
            var t = RecursiveSum(2, 3, 1); // 3 * 4 * 5 * 6 = 360
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
