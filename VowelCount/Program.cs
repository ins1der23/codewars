using System.Collections.Generic;
int GetVowelCount(string str)
{
    int vowelCount = 0;
    string vowels = "aeiou";
    foreach (var letter in str)
        if (vowels.Contains(letter)) vowelCount++;
    return vowelCount;
}

Console.WriteLine(GetVowelCount("imgoingforgoogle"));


int GetVowelCountLinq(string str)
{
    return str.Count(i => "aeiou".Contains(i));
}
