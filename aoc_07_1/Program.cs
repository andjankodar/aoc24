// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

var rows = File.ReadAllLines("input.txt").Select(x => Regex.Matches(x, "([0-9])+").Select(y => ulong.Parse(y.Value)).ToArray()).ToArray();

ulong correct = 0;
var sums = new List<ulong>();
var start = Stopwatch.GetTimestamp();

for (var i = 0; i < rows.Length; i++)
{
    var expected = rows[i][0];
    var values = rows[i].Take(new Range(1, rows[i].Length)).ToArray();
    Evaluate(expected, rows[i][1], values, 1);

    if (sums.Contains(expected))
    {

        correct += expected;
    }

    sums.Clear();
}

Console.WriteLine($"Correct: {correct} {Stopwatch.GetElapsedTime(start).TotalMilliseconds} ms");

void Evaluate(ulong expected, ulong current, ulong[] row, int index)
{
    var added = current + row[index];
    var multiplied = current * row[index];
    var concat = ulong.Parse(current.ToString()+ row[index].ToString());

    if (index + 1 >= row.Length)
    {
        sums.Add(added);
        sums.Add(multiplied);
        sums.Add(concat);
    }
    else
    {
        Evaluate(expected, added, row, index + 1);
        Evaluate(expected, multiplied, row, index + 1);
        Evaluate(expected, concat, row, index + 1);
    }
}