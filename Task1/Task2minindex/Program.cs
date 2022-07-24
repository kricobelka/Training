using System;

namespace Task2minindex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Number of elements");
            int N = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];
            for (int el = 0; el < array1.Length; el++)
            {
                Console.WriteLine("Please insert elements of the array");
                array1[el] = int.Parse(Console.ReadLine());
            }
            int max2 = 0;
            int j = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (max2 <= array1[i])
                {
                    max2 = array1[i];
                    j = i;
                }
            }
            Console.WriteLine("Max element is: " + " " + max2);
            Console.WriteLine("Min index of the max element is" + " " + j);
            Console.ReadKey();
        }
    }
}
