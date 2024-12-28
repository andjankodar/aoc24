
var secrets = File.ReadAllLines("input.txt").Select(x => long.Parse(x)).ToArray();
long sum = 0;

var secretsCache = new Dictionary<long, long>();
var sequences = new List<List<(int prize, int change)>>();
var test = new long[] { 123 };

foreach (var secret in secrets)
{
    long seed = secret;
    var changes = new List<(int prize, int change)>();
    
    for (var i = 0; i < 2000; i++)
    {
        seed = GetNextSecret(seed, changes);
    }
    
    sum += secret;
    sequences.Add(changes);
}

var markets = new List<Dictionary<string, long>>();

// Map sequences to bananas from that buyer
foreach (var changes in sequences)
{
    var changeDictionary = new Dictionary<string, long>();
    
    for (var i = 3; i < changes.Count; i++)
    {
        var changeSequence = $"{changes[i - 3].change},{changes[i - 2].change},{changes[i - 1].change},{changes[i].change}";
        var prize = changes[i].prize;

        if (!changeDictionary.ContainsKey(changeSequence))
        {
            changeDictionary.Add(changeSequence, prize);
        }
    }

    markets.Add(changeDictionary);
}

var bestBuy = new Dictionary<string, long>();

// Map sequences to bananas from all buyers at first occurence
foreach (var market in markets)
{
    var seqs = market.Keys.ToArray();
    
    for (var j = 0; j < seqs.Length; j++)
    {
        if (bestBuy.ContainsKey(seqs[j]))
        {
            bestBuy[seqs[j]] = bestBuy[seqs[j]] + market[seqs[j]];
        }
        else
        {
            bestBuy.Add(seqs[j], market[seqs[j]]);
        }
    }
}

var best = new KeyValuePair<string, long>();
// Find the best deal
foreach (var buy in bestBuy)
{
    if(buy.Value > best.Value)
    {
        best = buy;
    }
}

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Most bananas: {best.Value} for sequence {best.Key}");


long GetNextSecret(long secret, List<(int prize, int change)> changes)
{
    var input = secret;

    if (secretsCache.ContainsKey(input))
    {
        secret = secretsCache[secret];
    }
    else
    {
        // step 1
        secret = Prune(Mix(secret, secret * 64));

        // step 2
        secret = Prune(Mix(secret, secret / 32));

        // step 3
        secret = Prune(Mix(secret, secret * 2048));

        secretsCache.Add(input, secret);
    }

    var n1 = int.Parse(input.ToString().Last().ToString());
    var n2 = int.Parse(secret.ToString().Last().ToString());
    changes.Add((n2, n2 - n1));

    return secret;
}

long Mix(long secret, long operand)
{
    return secret ^ operand;
}

long Prune(long secret)
{
    return secret % 16777216;
}