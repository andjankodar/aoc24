using System;
using System.Text.RegularExpressions;

// Problem 1
var input = File.ReadAllText("input.txt");
var matches = Regex.Matches(input, "[0-9]+");

var leftColumn = new List<int>();
var rightColumn = new List<int>();

for (int i = 0; i < matches.Count; i++)
{
    if(i%2 == 0)
    {
        rightColumn.Add(int.Parse(matches[i].Value));
    }
    else
    {
        leftColumn.Add(int.Parse(matches[i].Value));
    }
}

// Problem 2
var score = 0;

foreach (var number in leftColumn)
{
    var times = rightColumn.Count(n => n == number);
    score += times * number;
}

Console.WriteLine($"Total score: {score}");