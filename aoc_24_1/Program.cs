using System.Text.RegularExpressions;

var testInput = File.ReadAllText("testInput.txt");
var input = File.ReadAllText("input.txt"); ;

var inputWires = input.Split("\r\n\r\n")[0].Split("\r\n");
var gates = input.Split("\r\n\r\n")[1].Split("\r\n");

var wireStatus = new Dictionary<string, bool>();
var outputGateDictionary = new Dictionary<string, (string w1, string gate, string w2)>();

GetInitialWireOutput();
StoreGates();

while(outputGateDictionary.Count > 0)
{
    foreach(var output in outputGateDictionary.Keys)
    {
        if(wireStatus.ContainsKey(output))
        {
            continue;
        }

        var input1 = outputGateDictionary[output].w1;
        var input2 = outputGateDictionary[output].w2;
        var gate = outputGateDictionary[output].gate;
        
        if (wireStatus.ContainsKey(input1) && wireStatus.ContainsKey(input2))
        {
            var val1 = wireStatus[input1];
            var val2 = wireStatus[input2];

            switch(gate)
            {
                case "AND":
                    wireStatus.Add(output, val1 && val2);
                    break;
                case "OR":
                    wireStatus.Add(output, val1 || val2);
                    break;
                case "XOR":
                    wireStatus.Add(output, val1 ^ val2);
                    break;
            }
        }
    }    

    foreach (var wire in wireStatus.Keys.Where(k => outputGateDictionary.ContainsKey(k)))
    {
        outputGateDictionary.Remove(wire);
    }
}

var result = string.Empty;
foreach (var wire in wireStatus.Keys.Order().Reverse())
{
    if (!wire.StartsWith('z'))
    {
        continue;
    }

    result += wireStatus[wire] ? "1" : "0";
}

Console.WriteLine(Convert.ToInt64(result, 2));


void StoreGates()
{
    foreach (var gate in gates)
    {
        var matches = Regex.Matches(gate, "([a-z0-9A-Z]+)");
        var w1 = matches[0].Value;
        var op = matches[1].Value;
        var w2 = matches[2].Value;
        var wOut = matches[3].Value;

        outputGateDictionary.Add(wOut, (w1, op, w2));    
    }
}

void GetInitialWireOutput()
{
    foreach (var input in inputWires)
    {
        if (input == string.Empty)
        {
            break;
        }

        var wire = input.Substring(0, 3);
        var value = input[input.Length - 1].ToString();
        wireStatus.Add(wire, value == "1" ? true : false);
    }
}
