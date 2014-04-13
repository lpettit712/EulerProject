using System.Collections.Generic;
using System.Linq;

namespace EulerProject
{
    public class Problem2
    {
        public long GetTotalSum(int maxValue)
        {
            long number1 = 1;
            long number2 = 2;
            long newValue = number1 + number2;
            long total = 2;
            while (newValue <= maxValue)
            {
                number1 = number2;
                number2 = newValue;
                total = newValue%2 == 0 ? newValue + total : total;
                newValue = number1 + number2;
            }
            return total;
        }

        public long FibbonacciSumEven(int maxValue)
        {
            //total should always start at 2
            return FibonacciRecursive(maxValue, 1, 2, 2);

        }

        private long FibonacciRecursive(int maxValue, long number1, long number2, long total)
        {
            long newValue = number1 + number2;
            if (newValue >= maxValue)
                return total;

            total = newValue%2 == 0 ? newValue + total : total;
            return FibonacciRecursive(maxValue, number2, newValue, total);
        }

        //public static List<long> LoadFibonacciList(int maxValue)
        //{
        //    var fibonacciList = new List<long>();
        //    if (fibonacciList.Count == 0)
        //    {
        //        fibonacciList.Add(1);
        //        fibonacciList.Add(2);
        //    }

        //    int lastIndex = fibonacciList.Count - 1;
        //    while (fibonacciList[lastIndex] < maxValue)
        //    {
        //        long lastNumber = fibonacciList[lastIndex];
        //        int secondToLastIndex = fibonacciList.Count - 2;
        //        long secondToLastNumber = fibonacciList[secondToLastIndex];

        //        long newValue = GetNewValue(lastNumber, secondToLastNumber);
        //        fibonacciList.Add(newValue);

        //        lastIndex++;
        //    }

        //    return fibonacciList;
        //}

        //public static long GetNewValue(long value1, long value2)
        //{
        //    long x = value1;
        //    long y = value2;

        //    long z = x + y;

        //    return z;
        //}

        //public static List<long> GetEvenValues(List<long> fibonacciList)
        //{
        //    var evenFibonacciList = new List<long>();
        //    foreach (long item in fibonacciList)
        //    {
        //        if (item%2 == 0)
        //        {
        //            evenFibonacciList.Add(item);
        //        }
        //    }

        //    return evenFibonacciList;
        //}

        //public long GetSum(List<long> list)
        //{
        //    long sum = list.Sum();
        //    //Console.WriteLine(Sum);
        //    //Console.ReadLine();
        //    return sum;
        //}
    }
}