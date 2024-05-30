﻿// See https://aka.ms/new-console-template for more information
using System.Text;

string str = Console.ReadLine();
StringBuilder nums = new StringBuilder();
StringBuilder letters = new StringBuilder();
StringBuilder other = new StringBuilder();

for (int i = 0; i < str.Length; i++)
{
    char chartext = str[i];

    if (char.IsDigit(chartext))
    {
        nums.Append(chartext);
    }
    else if (char.IsLetter(chartext))
    {
        letters.Append(chartext);
    }
    else
    {
        other.Append(chartext);
    }
}
Console.WriteLine($"{nums}\n{letters}\n{other}");
        


