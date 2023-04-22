
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System;
using System.Linq;

int ExcludeMax(int[] distance, List<int> excludeMax)
{
    int pivotI = Array.IndexOf(distance, distance.Min());
    int maxI = pivotI;
    for (int i = 0; i < distance.Length; i++)
    {
        if (distance[i] > distance[maxI] && !excludeMax.Contains(i)) maxI = i;
    }
    excludeMax.Add(maxI);
    return distance[maxI];
}

int ExcludeMin(int[] distance, List<int> exclude, List<int> excludeMax)
{
    int pivotI = Array.IndexOf(distance, distance.Max());
    int minI = pivotI;
    for (int i = 0; i < distance.Length; i++)
        if (distance[i] < distance[minI] && !exclude.Contains(i) && !excludeMax.Contains(i)) minI = i;
    exclude.Add(minI);
    return distance[minI];
}

int FindTrueMax(int[] cities, int city, int getDistance, List<int> excludeMax)
{
    int max = 0;
    int i = 0;
    while (i < cities.Length)
    {
        var minRange = new List<int>();
        int count = city;
        max = ExcludeMax(cities, excludeMax);
        int tempLeft = getDistance - max;
        Console.WriteLine($"{max} - текущий макс, {tempLeft} - остаток расстояния");
        count--;
        while (count > 0)
        {
            int min = ExcludeMin(cities, minRange, excludeMax);
            tempLeft = tempLeft - min;
            count--;
        }
        if (tempLeft >= 0) return max;
        i++;
    }
    return 0;
}

List<int> FindCities(int[] cities, int city, int getDistance, List<int> excludeMax)
{
    var result = new List<int>();
    while (city > 0)
    {
        int trueMax = FindTrueMax(cities, city, getDistance, excludeMax);
        Console.WriteLine(trueMax);
        result.Add(trueMax);
        if (trueMax == 0) break;
        getDistance = getDistance - trueMax;
        city--;
    }
    return result;
}

// List<int> distance = new List { 91, 74, 85, 73, 81, 87, 75 }; // список расстояний до городов
int[] cities = new int[] { 91, 74, 85, 81, 87, 87, 73, 73 };
int length = cities.Length;
int getDistance = 219; // максимальное расстояние
int city = 3; // количество городов
var excludeMax = new List<int>(); // пройденный максимальные числа

var finded = FindCities(cities, city, getDistance, excludeMax);



Console.WriteLine();
Console.WriteLine(String.Join(' ', finded));

















