var input = File.ReadAllLines("input.txt");
var towels = input[0].Split(", ").OrderBy(t => t.Length).Reverse().ToArray();
var patterns = input.Skip(2).ToArray();
var baseTowels = new List<string>();
long possibleArrangements = 0;
var composites = new Dictionary<string, int>();
var patternCache = new Dictionary<string, long>();

foreach (var towel in towels)
{
    var result = GetTowelCombos(towel, towels.Where(t => t != towel).ToArray());

    if (result == 0)
    {
        baseTowels.Add(towel);
    }
    else
    {
        composites.Add(towel, result);
    }
}

foreach (var pattern in patterns)
{
    var arrangements = Matches(pattern);
    
    if (arrangements > 0)
    {
        possibleArrangements += arrangements;
    }
}

Console.WriteLine($"Possible arrangements: {possibleArrangements}");

int GetTowelCombos(string baseTowel, string[] t)
{
    var matches = 0;
    foreach (var towel in t)
    {
        if (towel.Equals(baseTowel))
        {
            matches++;
        }

        if (baseTowel.StartsWith(towel))
        {
            var remaining = baseTowel.Substring(towel.Length);

            if (remaining is not null)
            {
                matches += (GetTowelCombos(remaining, t));
            }
        }
    }

    return matches;
}

long Matches(string pattern)
{
    if(patternCache.ContainsKey(pattern))
    {
        return patternCache[pattern];
    }

    long matches = 0;


    foreach (var towel in towels)
    {
        if (towel.Equals(pattern))
        {
            matches++;
        }

        if (pattern.StartsWith(towel))
        {
            var remaining = pattern.Substring(towel.Length);

            if (remaining is not null)
            {
                matches += Matches(remaining);
            }
        }
    }

    patternCache.Add(pattern, matches);
    return matches;
}