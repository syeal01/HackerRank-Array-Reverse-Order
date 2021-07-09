using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        arr.Reverse();
        foreach (var item in arr)
            System.Console.Write($"{item} ");
    }
}
