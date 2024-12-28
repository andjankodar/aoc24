using System.Text.RegularExpressions;

var input = File.ReadAllLines("input.txt");
var A = new List<(int x, int y)>();
var B = new List<(int x, int y)>();
var Prize = new List<(int x, int y)>();
int total = 0;

foreach (var line in input)
{
    if(line.StartsWith("Button A"))
    {
        var matches = Regex.Matches(line, "(\\d+)(\\d+)");
        A.Add((int.Parse(matches[0].Value), int.Parse(matches[1].Value)));
    }
    else if (line.StartsWith("Button B"))
    {
        var matches = Regex.Matches(line, "(\\d+)(\\d+)");
        B.Add((int.Parse(matches[0].Value), int.Parse(matches[1].Value)));
    }
    else if (line.StartsWith("Prize"))
    {
        var matches = Regex.Matches(line, "(\\d+)(\\d+)");
        Prize.Add((int.Parse(matches[0].Value), int.Parse(matches[1].Value)));
    }
}

for(int i = 0; i < Prize.Count; i++)
{
    CalcCheapest(A[i], B[i], Prize[i]);

}

Console.WriteLine($"Total: {total}");

int CalcCheapest((int X, int Y) A, (int X, int Y) B, (int X, int Y) Prize)
{
    var cost = new List<int>();
    
    for (int i = 0; i < 100; i++)
    {
        for (int j = 0; j < 100; j++)
        {
            var X = A.X * i + B.X * j;
            var Y = A.Y * i + B.Y * j;

            if (X == Prize.X && Y == Prize.Y)
            {
                cost.Add(i*3 + j);
            }

            if(X > Prize.X || Y > Prize.Y)
            {
                break;
            }
        }
    }

    cost.Sort();
    var cheapest = cost.FirstOrDefault(-1);
    
    if(cheapest > 0)
    {
        total += cheapest;
    }
   
    return cheapest;
}

