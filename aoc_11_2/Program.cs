var stones = File.ReadAllText("input.txt").Split(' ').Select(x => long.Parse(x)).ToArray();
long stoneCount = 0;
var cache = new Dictionary<(long, int), long>();

for (int i = 0; i < stones.Length; i++)
{
    stoneCount += Count(stones[i], 75);
}

long Count(long stone, int steps)
{    
    if(steps == 0)
    {
        return 1;
    }

    if (stone == 0)
    {
        if(cache.ContainsKey((1, steps -1)))
        {
            return cache[(1, steps - 1)];
        }
        var result = Count(1, steps - 1);
        cache.Add((1, steps - 1), result);

        return result;
    }

    var inputAsString = stone.ToString();
    if (inputAsString.Length % 2 == 0)
    {
        var first = int.Parse(inputAsString.Substring(0, inputAsString.Length / 2));
        var second = int.Parse(inputAsString.Substring(inputAsString.Length / 2));

        long result1 = 0;
        long result2 = 0;

        if (cache.ContainsKey((first, steps - 1)))
        {
            result1 = cache[(first, steps - 1)];
        }
        else
        {
            result1 = Count(first, steps - 1);
            cache.Add((first, steps - 1), result1);
        }

        if (cache.ContainsKey((second, steps - 1)))
        {
            result2 = cache[(second, steps - 1)];
        }
        else
        {
            result2 = Count(second, steps - 1);
            cache.Add((second, steps - 1), result2);
        }

        return result1 + result2;
    }
    
    if(cache.ContainsKey((stone * 2024, steps - 1)))
    {
        return cache[(stone * 2024, steps - 1)];
    }

    var result3 = Count(stone * 2024, steps - 1);
    cache.Add((stone * 2024, steps - 1), result3);
    return result3;
}

Console.WriteLine($"Stones: {stoneCount}");