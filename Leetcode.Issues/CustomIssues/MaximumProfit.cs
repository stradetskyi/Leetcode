namespace Leetcode.Issues.CustomIssues
{
    /// <summary>
    /// This is a C# task. Please develop this as a console app.
    /// 
    /// Assume an array of integers representing the price of EUR against another currency during a given time period.
    /// 
    /// You need to know “what would be the best price to buy and the best price to sell so I could achieve maximum profit?”
    /// 
    /// Example #1:
    /// [4, 2, 8, 6, 7, 12, 3, 25, 21, 30, 1]
    /// 
    /// The answer of the above would be to buy at the 2nd value (2) and sell at the 10th value(30) for a maximum profit of 28.
    /// 
    /// Example #2:
    /// [45, 56, 5, 7, 3, 57, 23, 24, 12, 2, 40]
    /// 
    /// The answer of the above would be to buy at the 5th value(3) and sell at the 6th value(57) for a maximum profit of 54.
    /// 
    /// Notes:
    /// Do not sort the array.Remember, the values are values that happened over a time period, so sorting them would make no sense.
    /// 
    /// Program input: array of integers
    /// Program output: “buy at buyPrice and sell at sellPrice for a maximum profit of maximumProfit”
    /// 
    /// You should also write unit tests and test various scenarios to ensure that your actual output is the expected output.
    /// </summary>
    public class MaximumProfit
    {
        /// <summary>
        /// Linear solution where we search one by one. First - maximum and then minimum on the left side before maximum
        /// </summary>
        /// <param name="ints">Input rates by some period</param>
        /// <returns>Maximum profit</returns>
        public int MaximumProfitSearch_LinearSolution(int[] ints)
        {
            int sellPriceIndex = 0;
            int sellPrice = ints[0]; //search max number sellPrice
            for (int i = 0; i < ints.Length; i++)
            {
                if (sellPrice < ints[i])
                {
                    sellPriceIndex = i;
                    sellPrice = ints[i];
                }
            }

            int buyPrice = ints[0]; //search min number buyPrice
            for (int i = 0; i < sellPriceIndex; i++)
            {
                if (buyPrice > ints[i])
                {
                    buyPrice = ints[i];
                }
            }

            var maximumProfit1 = sellPrice - buyPrice;
            return maximumProfit1;
        }

        /// <summary>
        /// Improved solution, where we use only one cycle
        /// new[] { 4, 2, 8, 6, 7, 12, 3, 25, 21, 30, 1 }
        /// 
        /// 4, 1 (4, 1)
        /// 2, 30 (2, 30)
        /// 8, 21 (2, 30)
        /// 6, 25 (2, 30)
        /// 7, 3 (2, 30)
        /// 12, 12 (2, 30)
        /// </summary>
        /// <param name="ints">Input rates by some period</param>
        /// <returns>Maximum profit</returns>
        public int MaximumProfitSearch_Improved(int[] ints)
        {
            int buyPriceIndex = 0;
            int buyPrice = ints[0]; //search min number buyPrice

            int sellPriceIndex = ints.Length - 1;
            int sellPrice = ints[ints.Length - 1]; //search max number sellPrice

            for (int i = 1; i < ints.Length; i++)
            {
                var index = ints.Length - 1 - i;
                if (sellPrice < ints[index] && index > buyPriceIndex)
                {
                    sellPriceIndex = index;
                    sellPrice = ints[index];
                }

                if (buyPrice > ints[i] && i < sellPriceIndex)
                {
                    buyPriceIndex = i;
                    buyPrice = ints[i];
                }
            }

            //calculate profit
            var maximumProfit = sellPrice - buyPrice;
            return maximumProfit;
        }
    }
}
