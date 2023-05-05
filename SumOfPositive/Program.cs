int PositiveSum(int[] arr)
{
    return arr.Where(item => item > 0)
              .Sum();
}


var numbers = new int[] { -1, -2, -3, -4, -5 };

Console.WriteLine(PositiveSum(numbers));