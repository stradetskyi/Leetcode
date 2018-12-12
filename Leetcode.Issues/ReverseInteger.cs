using System;
using System.Collections.Generic;

namespace Leetcode.Issues
{
    public class ReverseInteger
    {
        /// <summary>
        /// https://leetcode.com/problems/reverse-integer/
        /// </summary>
        public int Reverse(int x)
        {
            Stack<int> numbers = new Stack<int>();

            int n = x;
            while (n != 0)
            {
                decimal d = n;
                decimal newD = d / 10;
                int truncate = (int)Math.Truncate(newD);
                int minedNum = (int)((newD + (truncate * (-1))) * 10);

                numbers.Push(minedNum);

                n = truncate;
            }

            int newX = 0;
            int pos = 1;
            while (numbers.Count > 0)
            {
                int num = numbers.Pop();
                if (pos == 1000000000 && (newX > 147483647 || newX < -147483648) && Math.Abs(num) >= 2)
                {
                    newX = 0;
                }
                else
                {
                    newX = newX + num * pos;
                }

                pos = pos * 10;
            }
            return newX;
        }
    }
}
