using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_3_1
{
    class Program
    {
        public enum SortOrder { Asc,Desc};
        public static string IsSorted(int[] arr,SortOrder order)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i; j < arr.Length; j++)
                    if (order == SortOrder.Asc)
                    {
                        if (arr[i] > arr[j])
                            return "Array is not sorted by asc";
                    }
                    else if(order == SortOrder.Desc)
                        if (arr[i] < arr[j])
                            return "Array is not sorted by dsc";
            string temp = (order == SortOrder.Asc) ? "by asc" : "by desc";
            return ("Array is sorted " + temp);
        }

        public static void ShowArray(int[] arr)
        {
            foreach(int a in arr)
                Console.Write(a + " ");
            Console.WriteLine();
        }

        public static int[] ArraySort(int[] arr,SortOrder order)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i; j < arr.Length; j++)
                {
                    if (order == SortOrder.Asc)
                    {
                        if (arr[i] > arr[j])
                        {
                            int temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                    }
                    else if (order == SortOrder.Desc)
                    {
                        if (arr[i] < arr[j])
                        {
                            int temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                    }
                } 
              return arr;
        } 
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 2,4,1,5,3 };
            ShowArray(arr);
            ArraySort(arr,SortOrder.Desc);
            ShowArray(arr);
            Console.Write(IsSorted(arr,SortOrder.Asc));
            Console.ReadKey();
        }
    }
}
