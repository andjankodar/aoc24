
var stones = File.ReadAllText("input.txt").Split(' ').Select(x => long.Parse(x)).ToArray();
var input = stones;
var result = 0;

for (int i = 0; i < 25; i++) 
{
    input = Blink(input);
}

long[] Blink(long[] input)
{
    var output = new List<long>();

    for (int j = 0; j < input.Length; j++)
    {
        if (input[j] == 0)
        {
            output.Add(1);
            continue;
        }
        var inputAsString = input[j].ToString();

        if (inputAsString.Length % 2 == 0)
        {
            var first = int.Parse(inputAsString.Substring(0, inputAsString.Length / 2));
            var second = int.Parse(inputAsString.Substring(inputAsString.Length / 2));
            output.Add(first);
            output.Add(second);
            continue;
        }

        output.Add(input[j] * 2024);
    }

    return output.ToArray();
}


Console.WriteLine($"Stones: {input.Length}");