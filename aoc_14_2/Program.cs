using System.Text.RegularExpressions;

var input = File.ReadAllLines("input.txt");

var robots = new List<(int pX, int pY, int vX, int vY)>();
var q1 = 0;
var q2 = 0;
var q3 = 0;
var q4 = 0;

for (int i = 0; i < input.Length; i++)
{
    var matches = Regex.Matches(input[i], "(-*\\d+)").Select(x => int.Parse(x.Value)).ToArray();
    robots.Add((matches[0], matches[1], matches[2], matches[3]));
}

var width = 101;
var height = 103;
var bots = robots.ToArray();
var tree = false;
var seconds = 0;

while (!tree && seconds < 10000)
{
    for (int j = 0; j < bots.Length; j++)
    {
        var newPos = Move(1, bots[j]);
        bots[j].pX = newPos.pX;
        bots[j].pY = newPos.pY;       
    }

    var botsWithBros = CountRobotsWithNeighbours();

    if (botsWithBros.Count > bots.Length / 4)
    {
        Print();
        tree = true;        
    }
    
    seconds++;
}

Console.WriteLine($"Tree found after {seconds} seconds");

HashSet<(int X, int Y)> CountRobotsWithNeighbours()
{
    var bwn = new HashSet<(int X, int Y)>();
    
    for (int i = 0; i < bots.Length; i++)
    {
        var neighbours = 0;
        var bot = bots[i];

        if (bots.Any(b => b.pX == bot.pX - 1 && b.pY == bot.pY))
        {
            neighbours++;
        }

        if (bots.Any(b => b.pX == bot.pX + 1 && b.pY == bot.pY))
        {
            neighbours++;
        }

        if (bots.Any(b => b.pX == bot.pX && b.pY == bot.pY -1))
        {
            neighbours++;
        }

        if (bots.Any(b => b.pX == bot.pX && b.pY == bot.pY + 1))
        {
            neighbours++;
        }

        if (neighbours >= 4)
        {
            bwn.Add((bot.pX, bot.pY));
        }        
    }

    return bwn;
}


(int pX, int pY) Move(int times, (int pX, int pY, int vX, int vY) bot)
{
    var dX = Math.Abs(bot.vX * times) % width;
    var dY = Math.Abs(bot.vY * times) % height;

    var endX = bot.vX < 0 ? bot.pX - dX : bot.pX + dX;
    var endY = bot.vY < 0 ? bot.pY - dY : bot.pY + dY;

    if (endX < 0)
    {
        endX = endX + width;
    }
    else if (endX >= width)
    {
        endX = endX - width;
    }

    if (endY < 0)
    {
        endY = endY + height;
    }
    else if (endY >= height)
    {
        endY = endY - height;
    }

    return (endX, endY);
}

void Print()
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (bots.Any(r => r.pY == i && r.pX == j))
            {
                Console.Write($"X");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("=================================================================");
}
