using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededleri daxil edin");
            int[] arr1 = { 27, 51, 33, 8, 11, 15, 10, 56, 23, 78, 23, 54, 32, 234, 434, 23, 124};
            Sort(arr1);
            foreach(int item in arr1)
            {
                Console.WriteLine(item);
            }
        }
        static int[] Sort(int[] a)
        {
            int m = 0;
            int i = 1;
            for (int b = 1; b < a.Length; b++)
            {
                foreach (int item in a)
                {
                    if (item > a[i])
                    {
                        int temp = a[m];
                        a[m] = a[i];
                        a[i] = temp;

                    }
                    if (i == (a.Length-1))
                    {
                        break;
                    }
                    i++;
                    m++;
                }
                i = 1;
                m = 0;
                
            }
            return a;
        }
    }
}
