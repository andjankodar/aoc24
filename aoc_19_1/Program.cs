var input = File.ReadAllLines("input.txt");
var towels = input[0].Split(", ");

var patterns = input.Skip(2).ToArray();
var baseTowels = new List<string>();
var possiblePatterns = 0;

foreach (var towel in towels)
{
    if (!IsCompositeTowel(towel, towels.Where(t => t != towel).ToArray()))
    {      
        baseTowels.Add(towel);
    }
}

foreach (var pattern in patterns.Where(CanMatch))
{
    possiblePatterns++;
}

Console.WriteLine($"Possible patterns: {possiblePatterns}");

// Find towels made up of smaller towel patterns
bool IsCompositeTowel(string baseTowel, string[] t)
{
    foreach (var towel in t)
    {
        if (towel.Equals(baseTowel))
        {            
            return true;
        }

        if (baseTowel.StartsWith(towel))
        {
            var remaining = baseTowel.Substring(towel.Length);

            if (remaining is not null)
            {
                if (IsCompositeTowel(remaining, t))
                {
                    return true;
                }
            }
        }
    }

    return false;
}


bool CanMatch(string pattern)
{
    foreach(var towel in baseTowels)
    {
        if (towel.Equals(pattern))
        {            
            return true;
        }

        if (pattern.StartsWith(towel))
        {
            var remaining = pattern.Substring(towel.Length);
            
            if(remaining is not null)
            {
                if(CanMatch(remaining))
                {
                    return true;
                }
            }
        }
    }

    return false;
}