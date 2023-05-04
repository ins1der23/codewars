using System;
using System.Collections.Generic;



string MatrixToString(char[,] anyMatrix)
{
    string output = String.Empty;
    for (int rows = 0; rows < anyMatrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < anyMatrix.GetLength(1); columns++)
            output += anyMatrix[rows, columns] + " ";
        output += Environment.NewLine;
    }
    return output;
}

char[,] SeparateLiquids(char[,] glass)
{
    var density = new Dictionary<char, int>()
 {
    {'H', 4},
    {'W', 3},
    {'A', 2},
    {'O', 1},
 };

    char GetKeyFromValue(int valueVar)
    {
        foreach (char keyVar in density.Keys)
            if (density[keyVar] == valueVar) return keyVar;
        return ' ';
    }

    int height = glass.GetLength(0);
    int width = glass.GetLength(1);
    int size = height * width;

    int[] densityLine = new int[size];

    for (int i = 0; i < height; i++)
        for (int j = 0; j < width; j++)
            densityLine[j + i * width] = density[glass[i, j]];

    Array.Sort(densityLine);

    for (int i = 0; i < height; i++)
        for (int j = 0; j < width; j++)
            glass[i, j] = GetKeyFromValue(densityLine[j + i * width]);

    return glass;
}


char[,] SeparateLiquidsLinq(char[,] glass)
{

    var liquidsLine = glass.Cast<char>()  // приводит массив к типу char
                  .OrderBy(x => "OAWH".IndexOf(x)) // группирует в указонном порядке
                  .ToArray(); // формирует массив на выходе

    int height = glass.GetLength(0);
    int width = glass.GetLength(1);

    for (int i = 0; i < height; i++)
        for (int j = 0; j < width; j++)
            glass[i, j] = liquidsLine[j + i * width];

    return glass;
}

char[,] actual = new char[,] { { 'A','A','O','H' },
                                { 'A','H','W','O' },
                                { 'W','W','A','W' },
                                { 'H','H','O','O' } };

Console.WriteLine(MatrixToString(SeparateLiquids(actual)));

Console.WriteLine(MatrixToString(SeparateLiquidsLinq(actual)));