using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Задание 1:");
            ArrayList numberAsArray = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            for (int i = 0; i < numberAsArray.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(numberAsArray[i]);
                }
            }
            Console.WriteLine("\n");
            //Задание 2
            Console.WriteLine("Задание 2:");
            List<int> elements = new List<int> { 14, 23, 4, 6, 9, 10, 50 };
            int arifmetikZnachenie, sum = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                sum += elements[i];
            }
            arifmetikZnachenie = sum / elements.Count;
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] > arifmetikZnachenie)
                {
                    Console.WriteLine(elements[i]);
                }
            }
        }
    }
}