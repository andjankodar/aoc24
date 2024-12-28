using System;
using System.Text.RegularExpressions;

// Problem 1
var input = File.ReadAllText("input.txt");
var matches = Regex.Matches(input, "[0-9]+");

var leftColumn = new List<int>();
var rightColumn = new List<int>();

for (int i = 0; i < matches.Count; i++)
{
    if (i % 2 == 0)
    {
        rightColumn.Add(int.Parse(matches[i].Value));
    }
    else
    {
        leftColumn.Add(int.Parse(matches[i].Value));
    }
}

leftColumn.Sort();
rightColumn.Sort();

var distance = 0;

for (int i = 0; i < leftColumn.Count; i++)
{
    distance += Math.Abs(leftColumn[i] - rightColumn[i]);
}

Console.WriteLine($"Total distance: {distance}");