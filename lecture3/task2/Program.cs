﻿/*
cycle 'for'
*/
string Method(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method(10, "Bet");
//Console.WriteLine(res);

for(int i = 2; i <= 10; i++)
{
    for(int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}"); 
    }
    Console.WriteLine();
}
