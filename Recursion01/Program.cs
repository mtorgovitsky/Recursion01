using System;

namespace Recursion01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check if it's working:
            Console.WriteLine("The sum of 369: {0}", SumRecurs(369));
            Console.WriteLine("The sum of 653 {0}", SumRecurs(653));
            Console.WriteLine("The sum of 342: {0}", SumRecurs(342));
            Console.ReadKey();
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
