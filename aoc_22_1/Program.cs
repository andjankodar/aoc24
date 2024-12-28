using System.Net.Sockets;

var secrets = File.ReadAllLines("input.txt").Select(x => long.Parse(x)).ToArray();
long sum = 0;

var secretsCache = new Dictionary<long, long>();

foreach (var secret in secrets)
{
    long seed = secret;
    
    for (var i = 0; i < 2000; i++)
    {
        seed = GetNextSecret(seed);        
    }

    sum += seed;
}

Console.WriteLine($"Sum: {sum}");

long GetNextSecret(long secret)
{
    var input = secret;
    
    if(secretsCache.ContainsKey(input))
    {
        return secretsCache[secret];
    }

    // step 1
    secret = Prune(Mix(secret, secret * 64));

    // step 2
    secret = Prune(Mix(secret, secret / 32));

    // step 3
    secret = Prune(Mix(secret, secret * 2048));
    
    secretsCache.Add(input, secret);

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