using System.Collections.Immutable;
using System.Text.RegularExpressions;

var testInput = File.ReadAllText("testinput.txt");
var input = File.ReadAllText("input.txt");

var inputWires = input.Split("\r\n\r\n")[0].Split("\r\n");
var gates = input.Split("\r\n\r\n")[1].Split("\r\n");

var wireStatus = new Dictionary<string, bool>();
var outputDictionary = new SortedDictionary<string, (string w1, string gate, string w2)>();
var gateDictionary = new Dictionary<(string w1, string op, string w2), string>();
var swappedWires = new List<string>();

BuildGatesDictionary();
BuildOutputDictionary();

while (!EvaluateFullAdder())
{
}

swappedWires.Sort();
Console.WriteLine($"Swapped wires: {string.Join(",", swappedWires)}");

bool EvaluateFullAdder()
{    
    var carryBit = new Dictionary<string, string>();
    carryBit.Add("z00", GetOutWireFromGate("x00", "AND", "y00"));

    for (var i = 1; i < 45; i++)
    {
        var x = GetWireName('x', i);
        var y = GetWireName('y', i);
        var z = GetWireName('z', i);
        var previousZ = GetWireName('z', i - 1);

        var x_xor_y = string.Empty;
        var carryInWire = string.Empty;
        var zOut = string.Empty;


        //Z = (X XOR Y) XOR CARRY
        x_xor_y = GetOutWireFromGate(x, "XOR", y);

        if (carryBit.ContainsKey(previousZ))
        {
            carryInWire = carryBit[previousZ];
        }

        zOut = GetOutWireFromGate(x_xor_y, "XOR", carryInWire);

        if (string.IsNullOrEmpty(zOut))
        {
            //x_xor_y outputs to the wrong wire        
            
            var replaceWithOutput = GetCorrectWire(carryInWire, "XOR");

            if(gateDictionary.ContainsKey((x, "XOR", y)))
            {
                gateDictionary[(x, "XOR", y)] = replaceWithOutput;
            }
            else
            {
                gateDictionary[(y, "XOR", x)] = replaceWithOutput;
            }
            
            var swapWithGate = outputDictionary[replaceWithOutput];
            gateDictionary[swapWithGate] = x_xor_y;
            swappedWires.Add(x_xor_y);
            swappedWires.Add(replaceWithOutput);
            Console.WriteLine($"Replaced output {x_xor_y} with {replaceWithOutput}");
            return false;
        } else if (!zOut.StartsWith('z'))
        {
            // Sumwire needs to be a z-wire
            var faulty = zOut;
            var replaceWithOutput = GetWireName('z', i);
            var swapWithGate = outputDictionary[replaceWithOutput];
            gateDictionary[swapWithGate] = zOut;
            
            zOut = replaceWithOutput;           
         
            if (gateDictionary.ContainsKey((x_xor_y, "XOR", carryInWire)))
            {
                gateDictionary[(x_xor_y, "XOR", carryInWire)] = replaceWithOutput;
            }
            else
            {
                gateDictionary[(carryInWire, "XOR", x_xor_y)] = replaceWithOutput;
            }

            swappedWires.Add(faulty);
            swappedWires.Add(replaceWithOutput);
            Console.WriteLine($"Replaced output {faulty} with {replaceWithOutput}");
            return false;
        }

        var X_AND_Y = GetOutWireFromGate(x, "AND", y);

        if (string.IsNullOrEmpty(X_AND_Y))
        {
            Console.WriteLine($"No gate found for {x} AND {y}");
            throw new InvalidDataException();
        }

        var xor_AND_cin = GetOutWireFromGate(x_xor_y, "AND", carryInWire);

        var coutWire = string.Empty;
        
        if (string.IsNullOrEmpty(xor_AND_cin) || xor_AND_cin.StartsWith("z"))
        {
            coutWire = X_AND_Y;
        }
        else
        {
            coutWire = GetOutWireFromGate(X_AND_Y, "OR", xor_AND_cin);
        }

        if (string.IsNullOrEmpty(coutWire))
        {
            Console.WriteLine($"No gate found for {X_AND_Y} OR {xor_AND_cin}");
        }

        carryBit.Add(z, coutWire);
    }

    return true;
}

string GetCorrectWire(string input1, string op)
{
    foreach (var key in gateDictionary.Keys)
    {
        if (key.op == op && key.w1 == input1)
        {
            return key.w2;
        }
        else if (key.op == op && key.w2 == input1)
        {
            return key.w1;
        }
    }

    return string.Empty;
}

string GetWireName(char prefix, int num)
{
    return $"{prefix}{num.ToString("00")}";
}
string GetOutWireFromGate(string w1, string operand, string w2)
{
    var result = string.Empty;

    if (gateDictionary.ContainsKey((w1, operand, w2)))
    {
        result = gateDictionary[(w1, operand, w2)];
    }
    else if (gateDictionary.ContainsKey((w2, operand, w1)))
    {
        result = gateDictionary[(w2, operand, w1)];
    }

    return result;
}

void BuildOutputDictionary()
{
    foreach (var key in gateDictionary.Keys)
    {
        var output = gateDictionary[key];
        outputDictionary.Add(output, (key.w1, key.op, key.w2));
    }
}

void BuildGatesDictionary()
{
    foreach (var gate in gates)
    {
        var matches = Regex.Matches(gate, "([a-z0-9A-Z]+)");
        var w1 = matches[0].Value;
        var op = matches[1].Value;
        var w2 = matches[2].Value;
        var wOut = matches[3].Value;
        gateDictionary.Add((w1, op, w2), wOut);
    }
}

HashSet<string> MapInputsToOutput(string output, ImmutableHashSet<string> inputs)
{
    if(output.StartsWith('x') || output.StartsWith('y'))
    {
        return inputs.ToHashSet();
    }

    foreach (var outWire in outputDictionary.Keys)
    {
        if(outWire == output)
        {
            var in1 = outputDictionary[outWire].w1;
            var in2 = outputDictionary[outWire].w2;
            inputs.Add(in1);
            inputs.Add(in2);

            var r1 = MapInputsToOutput(in1, inputs.Add(in1));
            var r2 = MapInputsToOutput(in2, inputs.Add(in2));
            var result = new HashSet<string>();
            
            foreach (var item in r1)
            {
                result.Add(item);
            }

            foreach (var item in r2)
            {
                result.Add(item);
            }

            return result;
        }
    }

    return new HashSet<string>();
}