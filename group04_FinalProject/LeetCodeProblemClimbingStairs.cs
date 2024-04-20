using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace group04_FinalProject
{
    public class LeetCodeProblemClimbingStairs
    {
        /// <summary>
        /// Calculates the number of distinct ways to climb to the top of a staircase given n steps,
        /// where each time you can either climb 1 or 2 steps. The calculation uses a dynamic programming
        /// approach that optimizes space usage.
        /// </summary>
        /// <param name="n">The total number of steps to reach the top of the staircase.</param>
        /// <returns>The number of distinct ways to reach the top.</returns>
        public int ClimbStairs(int n)
        {
            if (n <= 1)
            {
                return 1; // There is only one way to climb one or zero steps (by not moving or taking one step).
            }

            int previous = 1;  // This variable will store the number of ways to reach the (i-1)th step.
            int current = 1;   // This variable will store the number of ways to reach the ith step.
            int temporary;     // This temporary variable will help in the iteration to store intermediate values.

            for (int i = 2; i <= n; i++)
            {
                temporary = current;              // Store current in temporary.
                current += previous;              // Current is now the sum of ways to get to the (i-1)th and (i-2)th steps.
                previous = temporary;             // Previous is updated to what was the current value before updating.
            }

            return current; // The current variable now holds the number of ways to reach the nth step.
        }
    }
}