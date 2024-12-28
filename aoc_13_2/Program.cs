using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
var input = File.ReadAllLines("input.txt");

var ButtonA = new List<(int dX, int dY)>();
var ButtonB = new List<(int dX, int dY)>();
var Prize = new List<(int X, int Y)>();

for (var i = 0; i< input.Length; i++)
{ 
    if (input[i].StartsWith("Button A"))
    {
        var matches = Regex.Matches(input[i], "(\\d+)(\\d+)");
        var xy = (int.Parse(matches[0].Value), int.Parse(matches[1].Value));
        ButtonA.Add(xy);
    }
    if (input[i].StartsWith("Button B"))
    {
        var matches = Regex.Matches(input[i], "(\\d+)(\\d+)");
        var xy = (int.Parse(matches[0].Value), int.Parse(matches[1].Value));
        ButtonB.Add(xy);
    }
    if (input[i].StartsWith("Prize"))
    {
        var matches = Regex.Matches(input[i], "(\\d+)(\\d+)");
        var xy = (int.Parse(matches[0].Value), int.Parse(matches[1].Value));
        Prize.Add(xy);
    }
}
long total = 0;

for (var i = 0; i < Prize.Count; i++)
{    
    var result = Calc(ButtonA[i], ButtonB[i], (Prize[i].X+10000000000000, Prize[i].Y+10000000000000)); 
    total += result;
}

Console.WriteLine($"Total: {total}");

long Calc((int dX, int dY) A, (int dX, int dY) B, (long X, long Y) Prize)
{
    var countA = (Prize.X * B.dY - B.dX * Prize.Y) / (A.dX * B.dY - B.dX * A.dY);
    var countB = (Prize.Y - countA * A.dY) / B.dY;

    if (A.dX * countA + B.dX * countB == Prize.X && A.dY * countA + B.dY * countB == Prize.Y)
    {
        var cost = countA * 3 + countB;
        return cost;
    }

    return 0;
}
