using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble sort");
            int[] numbers = { 2, 10, 3, 7, 1, 4, 3, 5, 8 };
            Print(numbers);
            BubbleSort(numbers);
            Print(numbers);
        }

        static void Print(int[] a)
        {
            string temp = "";
            for (int i = 0 ;i < a.Length; i++)
                temp += a[i].ToString();            
            Console.WriteLine(temp);
        }

        static void BubbleSort(int[] a)
        {
            for (int pass=a.Length-1; pass >= 0; pass--)
            {
                for (int i=0; i<pass; i++)
                {
                    if (a[i] > a[i+1])
                    {
                        // swap
                        int temp = a[i];
                        a[i] = a[i+1];
                        a[i+1] = temp;
                    }
                }
            }
        }
    }
}
