using System;
using System.Linq;


bool IsValid(int[][] square, int gap)
{

    bool LineAndColSum(int[][] square, int sum)
    {
        int colSum = 0;
        int lineSum = 0;
        for (int i = 0; i < square.Length; i++)
        {
            for (int j = 0; j < square.Length; j++)
            {
                lineSum += square[i][j];
                colSum += square[j][i];
            }
            if (colSum != sum || lineSum != sum) return false;
            colSum = 0;
            lineSum = 0;
        }
        return true;
    }

    bool DiagonalSum(int[][] square, int sum)
    {
        int firstDiagSum = 0;
        int secondDiagSum = 0;
        int j = square.Length - 1;
        for (int i = 0; i < square.Length; i++)
        {
            firstDiagSum += square[i][i];
            secondDiagSum += square[i][j];
            j--;

        }
        if (firstDiagSum != sum || secondDiagSum != sum) return false;
        return true;
    }

    bool CheckGap(int[][] square, int gap)
    {
        double max = square[0].Max();
        double min = square[0].Min();

        for (int i = 1; i < square.Length; i++)
        {
            if (square[i].Max() > max) max = square[i].Max();
            if (square[i].Min() < min) min = square[i].Min();
        }
        double quant = Math.Pow(square.Length, 2);
        if (gap != (max - min) / (quant - 1)) return false;
        return true;
    }

    int magic = square[0].Sum();

    if (LineAndColSum(square, magic) &&
        DiagonalSum(square, magic) &&
        CheckGap(square, gap))
        return true;
    else return false;
}

int[][] toCheck = new[]
    {
        new [] {9, 2, 7},
        new [] {4, 6, 8},
        new [] {5, 10, 3}
    };


Console.WriteLine(IsValid(toCheck, 1));




