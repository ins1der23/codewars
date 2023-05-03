using System;
using System.Collections.Generic;
int[] sam = new int[4];
int[] tom = new int[4];
int[] frank = new int[4];

var cards = new HashSet<int>();
var random = new Random();
int someRandom;

void FillSet(int[] cardSet)
{
    for (int i = 0; i < cardSet.Length; i++)
    {
        do someRandom = random.Next(12);
        while (cards.Contains(someRandom));
        cards.Add(someRandom);
        cardSet[i] = someRandom;
    }
}

FillSet(sam);
FillSet(tom);
FillSet(frank);

Console.WriteLine($"Sam {String.Join(' ', sam)}");
Console.WriteLine($"Tom {String.Join(' ', tom)}");
Console.WriteLine($"Frank {String.Join(' ', frank)}");

var cardsWeight = new Dictionary<int, int>
{
    {0, 10},
    {1, 11},
    {2, 12},
    {3,23},
    {4,24},
    {5,25},
    {6,36},
    {7,37},
    {8,38},
    {9,49},
    {10,50},
    {11,51}
};
int cardsValue;

int SumOfSet(int[] cardSet)
{
    int sum = 0;
    foreach (var card in cardSet)
    {
        cardsValue = cardsWeight[card];
        sum += cardsValue;
    }

    return sum;
}

Console.WriteLine();
Console.WriteLine($"Sam's sum = {SumOfSet(sam)}");
Console.WriteLine($"Tom's sum = {SumOfSet(tom)}");
Console.WriteLine($"Frank's sum = {SumOfSet(frank)}");