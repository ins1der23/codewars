using System;
using System.Collections.Generic;
using System.Linq;

int[] toSum = new int[] { 1, 10, 7, 8, 9, 7, 6, 7, 2 };
int SumNoDuplicates(int[] arr)
{
    Array.Sort(arr);
    HashSet<int> duplicates = new HashSet<int>();
    for (int i = 0; i < arr.Length - 1; i++)
        if (arr[i] == arr[i + 1]) duplicates.Add(arr[i]);
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (!duplicates.Contains(arr[i])) sum += arr[i];
    return sum;
}
Console.WriteLine(SumNoDuplicates(toSum));

