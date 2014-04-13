using System.Collections.Generic;
using System.Linq;

namespace EulerProject
{
    public class Problem1
    {
        public int GetSumOfALlMultiples(int number, List<int> multiples)
        {
            return Enumerable.Range(1, number - 1).Where(current => multiples.Any(mod => current % mod == 0)).Sum();

            int i = number;
            var multiplesOfThree = new List<int>();
            for (i = 0; i <= number; i++)
            {
                if (i%3 == 0)
                {
                    multiplesOfThree.Add(i);
                }
            }

            var multiplesOfFive = new List<int>();
            for (i = 0; i <= number; i++)
            {
                if (i%5 == 0)
                {
                    multiplesOfFive.Add(i);
                }
            }
            return sumOfAllMultiples(multiplesOfThree, multiplesOfFive);
        }

        public bool isMultiple(List<int> multiples, int number)
        {
            return multiples.Any(m => number%m == 0);
        }

        public int sumOfAllMultiples(List<int> multiplesOfThree, List<int> multiplesOfFive)
        {
            int sum1 = multiplesOfThree.Sum();
            int sum2 = multiplesOfFive.Sum();
            int totalSum = sum1 + sum2;
            return totalSum;
        }
    }
}