﻿using System;

namespace SimpleGenericsDemoWithMethod
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("GenericsDemo");
            Console.WriteLine(new string('*', 40));
            int firstValue = 2;
            int secondValue = 7;
            Console.WriteLine($"First value: {firstValue} / Second value: {secondValue}");
            Swap<int>(ref firstValue, ref secondValue);
            Console.WriteLine($"First value: {firstValue} / Second value: {secondValue}");
            Console.WriteLine(new string('*', 40));
            double firstDouble = 2.7644;
            double secondDouble = 3.77;
            Console.WriteLine($"First value: {firstDouble} / Second value: {secondDouble}");
            Swap<double>(ref firstDouble, ref secondDouble);
            Console.WriteLine($"First value: {firstDouble} / Second value: {secondDouble}");
        }

        // A generic method which will work with several data types. 
        public static void Swap<T>(ref T firstValue, ref T secondValue)
        {
            T tempValue;
            tempValue = firstValue;
            firstValue = secondValue;
            secondValue = tempValue;
        }
    }
}
