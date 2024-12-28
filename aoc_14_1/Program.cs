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

for(int j = 0; j < bots.Length; j++)
{
    var newPos = Move(100, bots[j]);

    if(newPos.pX >= 0 && newPos.pX < width / 2 && newPos.pY >= 0 && newPos.pY < height / 2)
    {
        q1++;
    }else if (newPos.pX > width / 2 && newPos.pX < width && newPos.pY >= 0 && newPos.pY < height / 2)
    {
        q2++;
    }
    else if (newPos.pX >= 0 && newPos.pX < width / 2 && newPos.pY > height / 2 && newPos.pY < height)
    {
        q3++;
    }
    else if (newPos.pX > width / 2 && newPos.pX < width && newPos.pY > height / 2 && newPos.pY < height)
    {
        q4++;
    }
}

Console.WriteLine($"Total: {q1 * q2 * q3 * q4}");

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
