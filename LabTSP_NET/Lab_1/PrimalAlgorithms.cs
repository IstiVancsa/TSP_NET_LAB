using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class PrimalAlgorithms
    {
        public bool IsPrimeEfficient(int x)
        {
            if (x == 1 || x == 2)
                return true;
            if (x % 2 == 0)
                return false;
            for (int d = 3; d <= Math.Sqrt(x); d = d + 2)
                if (x % d == 0)
                    return false;
            return true;
        }

        public bool IsPrimeInefficient(int x)
        {
            int counter = 0;
            for (int d = 1; d <= x; d++)
                if (x % d == 0)
                    counter++;
            if (counter == 2)
                return true;
            else
                return false;
        }

        public int GetMaxPrime_SmallerThenEfficient(int x)
        {

            while (true)
            {
                x--;
                if (IsPrimeEfficient(x))
                    return x;
            }
        }
        public int GetMaxPrime_SmallerThenInefficient(int x)
        {
            int max = -1;
            for (int i = 1; i < x; i++)
                if (IsPrimeInefficient(i))
                    if (i > max)
                        max = i;

            return max;
        }
    }
}
