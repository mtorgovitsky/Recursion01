using System;

namespace Recursion01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumRecurs(369));
        }

        #region Recursive Sum
        //Recursive function that calculates the sum of the digits.
        static int SumRecurs(int number)
        {
            if (number != 0)
            {
                return (number % 10 + SumRecurs(number / 10));
            }
            else return 0;
        }
        #endregion
    }
}
