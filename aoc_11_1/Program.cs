// See https://aka.ms/new-console-template for more information
var testInput = """
    125 17
    """;

var myInput = "112 1110 163902 0 7656027 83039 9 74";

var stones = myInput.Split(' ').Select(x => long.Parse(x)).ToArray();
var input = new List<long>();
input.AddRange(stones);

for (int i = 0; i < 25; i++)   //Blinks
{
    var output = new List<long>();
    for (int j = 0; j < input.Count; j++)
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

    input = new List<long>();
    input.AddRange(output);
}

Console.WriteLine($"Stones: {input.Count}");