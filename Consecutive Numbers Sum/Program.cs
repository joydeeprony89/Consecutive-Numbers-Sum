using System;
using System.Collections.Generic;

namespace Consecutive_Numbers_Sum
{
  class Program
  {
    static void Main(string[] args)
    {
      Program p = new Program();
      Console.WriteLine(p.ConsecutiveNumbersSum(63));
    }

    public int ConsecutiveNumbersSum(int n)
    {
      int count = 0;
      long end = 1;
      long sum = 0;
      List<long> list = new List<long>();
      // loop through until sum is less than n
      while (sum < n)
      {
        list.Add(end);
        sum += end;
        // when sum matches increase count as we have found a consicutive nos
        if (sum == n)
        {
          count++;
        }
        // break the loop as we have found our initial range of nos whose consicutive sum is n
        if (sum >= n) break;
        ++end;
      }
      // now loop through again for the list of nos whose consicutive sum is n
      for (int i = 0; i < list.Count; i++)
      {
        // condition when to stop ?
        // when we have reached at the end and we have found the last two elements whose sum is n.
        if (i == list.Count - 2) break;
        // deduct one by one nos from the head of the list
        sum -= list[i];
        // increase count after removing one element from the front of list gave sum == n
        if (sum == n)
        {
          count++;
          continue;
        }
        // if current sum is less than n then will add the next element in to the list.
        if (sum < n)
        {
          // new end
          end += 1;
          sum += end;
          list.Add(end);
        }
      }
      return count == 0 ? count : count + 1;
    }
  }
}
