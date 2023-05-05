using System;
using System.Diagnostics.Contracts;
using System.ComponentModel.DataAnnotations.Schema;
bool IsValid(int[][] square, int gap)
{

    int sum = gap;

    bool LinesSum(int[][] square, int sum)
    {
        foreach (var line in square)
            if (line.Sum() != sum) return false;
        return true;
    }

    bool ColumnSum(int[][] square, int sum)
    {
        int colSum = 0;
        for (int i = 0; i < square.Length; i++)
        {
            for (int j = 0; j < square.Length; j++)
            {
                colSum += square[j][i];
            }
            if (colSum != sum) return false;
            colSum = 0;
        }
        return true;
    }

    bool FirstDiagSum(int[][] square, int sum)
    {
        int diagSum = 0;
        for (int i = 0; i < square.Length; i++)
        {
            diagSum += square[i][i];
        }
        if (diagSum == sum) return true;
        else return false;
    }

    bool SecondDiagSum(int[][] square, int sum)
    {


        int diagSum = 0;
        int j = square.Length - 1;
        for (int i = 0; i < square.Length; i++)
        {
            diagSum += square[i][j];
            j--;
        }
        if (diagSum == sum) return true;
        else return false;
    }

    if (LinesSum(square, gap) &&
        ColumnSum(square, gap) &&
        FirstDiagSum(square, gap) &&
        SecondDiagSum(square, gap))
        return true;
    else return false;
}

bool LinesSum(int[][] square, int sum)
{
    foreach (var line in square)
        if (line.Sum() != sum) return false;
    return true;
}

bool ColumnSum(int[][] square, int sum)
{
    int colSum = 0;
    for (int i = 0; i < square.Length; i++)
    {
        for (int j = 0; j < square.Length; j++)
        {
            colSum += square[j][i];
        }
        if (colSum != sum) return false;
        colSum = 0;
    }
    return true;
}

bool FirstDiagSum(int[][] square, int sum)
{
    int diagSum = 0;
    for (int i = 0; i < square.Length; i++)
    {
        diagSum += square[i][i];
    }
    if (diagSum == sum) return true;
    else return false;
}

bool SecondDiagSum(int[][] square, int sum)
{


    int diagSum = 0;
    int j = square.Length - 1;
    for (int i = 0; i < square.Length; i++)
    {
        diagSum += square[i][j];
        j--;
    }
    if (diagSum == sum) return true;
    else return false;
}

int[][] toCheck = new[]
    {
        new [] {9, 2, 7},
        new [] {4, 6, 8},
        new [] {5, 10, 3}
    };

Console.WriteLine(LinesSum(toCheck, 18));
Console.WriteLine(ColumnSum(toCheck, 18));
Console.WriteLine(FirstDiagSum(toCheck, 18));
Console.WriteLine(SecondDiagSum(toCheck, 18));
Console.WriteLine(IsValid(toCheck, 18));