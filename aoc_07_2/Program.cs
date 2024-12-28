using System.Diagnostics;
using System.Text.RegularExpressions;


var grid = File.ReadAllLines("input.txt").Select(x => Regex.Matches(x, "([0-9])+").Select(y => long.Parse(y.Value)).ToArray()).ToArray();
long correct = 0;
var start = Stopwatch.GetTimestamp();
for (var i = 0; i < grid.Length; i++)
{
    var expected = grid[i][0];
    var values = grid[i].Skip(1).ToArray();

    if (Evaluate(expected, values))
    {
        correct += expected;
    }
}

Console.WriteLine($"Correct: {correct}. {Stopwatch.GetElapsedTime(start).TotalMilliseconds} ms");

bool Evaluate(long expected, long[] values)
{
    if(values.Length == 1)
    {
        return values[values.Length-1] == expected;
    }

    if(expected % values[values.Length - 1] == 0 && Evaluate(expected / values[values.Length - 1], values.Take(values.Length - 1).ToArray()))
    {
        return true;
    }

    if (expected > values[values.Length - 1] && Evaluate(expected - values[values.Length - 1], values.Take(values.Length - 1).ToArray()))
    {
        return true;
    }

    string target = expected.ToString();
    string last = values[values.Length - 1].ToString();

    if (target.Length > last.Length && target.EndsWith(last) && Evaluate(long.Parse(target.Substring(0, target.Length - last.Length)), values.Take(values.Length - 1).ToArray()))
    {
        return true;
    }

    return false;
}
