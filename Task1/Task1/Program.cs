﻿using System;
using System.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert number of elements");
            int N = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];
            for (int el = 0; el < array1.Length; el++)
            {
                Console.WriteLine("Please insert elements of the array");
                array1[el] = int.Parse(Console.ReadLine());
            }
            //output of all the elements from the array:
            //foreach (int el in array1)
            //{
            //    Console.WriteLine(el);
            //}

            //first option to output max value:
            int max2 = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (max2 <= array1[i])
                {
                    max2 = array1[i];
                }
            }
            //Console.WriteLine(max2);

            ////secod option:
            ////int max = array1.Max();
            //Console.WriteLine(max);
            Console.WriteLine("Max element is:" + " " + max2);
                Console.ReadKey();
            }
        }
    }

