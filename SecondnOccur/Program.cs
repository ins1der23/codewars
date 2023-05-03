int SecondSymbol(string str, char symbol)
{
    int count = 0;
    int res = -1;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == symbol) count++;
        if (count == 2) 
        {
            res = i;
            break;
        }
    }
    return res;
}

Console.WriteLine(SecondSymbol("Hello world", 'v')); 