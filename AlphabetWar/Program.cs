using System.Collections.Generic;

string AlphabetWar(string fight)
{
    var lettersWeight = new Dictionary<char, int>()
{
    {'w', 4},
    {'p', 3},
    {'b', 2},
    {'s', 1},
    {'m',-4},
    {'q',-3},
    {'d',-2},
    {'z',-1}

};
    int sum = 0;
    foreach (var letter in fight)
        if (lettersWeight.ContainsKey(letter))
            sum += lettersWeight[letter];

    return sum < 0 ? "Right side wins!" : sum > 0 ? "Left side wins!" : "Let's fight again!";

}

Console.WriteLine(AlphabetWar("ghjkl"));






