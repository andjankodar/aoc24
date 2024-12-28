using System.Text.RegularExpressions;

var testInput = File.ReadAllText("testinput.txt");
var input = File.ReadAllText("input.txt");

var inputWires = input.Split("\r\n\r\n")[0].Split("\r\n");
var gates = input.Split("\r\n\r\n")[1].Split("\r\n");

var gateDictionary = new Dictionary<(string w1, string op, string w2), string>();
var swappedWires = new List<string>();

BuildGatesDictionary();

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

        //Z = (X XOR Y) XOR CARRY
        var x_xor_y = GetOutWireFromGate(x, "XOR", y);
        var carryInWire = carryBit[previousZ];
        var zOut = GetOutWireFromGate(x_xor_y, "XOR", carryInWire);

        if (string.IsNullOrEmpty(zOut))
        {
            // x_xor_y outputs to the wrong wire        
            
            zOut = GetCorrectWire(carryInWire, "XOR");                                      // Find the other input wire in a gate with carryIn XOR. That is the correct output wire from x XOR y.
            var swapWithGate = gateDictionary.FirstOrDefault(kvp =>  kvp.Value == zOut);    // Find the gate that currently has zOut to swap with

            // Make the swap
            SetCorrectWire(x, "XOR", y, zOut);
            SetCorrectWire(swapWithGate.Key.w1, swapWithGate.Key.op, swapWithGate.Key.w2, x_xor_y);           
            
            // Store swapped wires for result
            swappedWires.Add(x_xor_y);
            swappedWires.Add(zOut);

            Console.WriteLine($"Replaced output {x_xor_y} with {zOut}");
        } 
        else if (!zOut.StartsWith('z'))
        {
            // x_xor_y XOR carryIn needs to be a z-wire
            var faultyZ = zOut;
            zOut = GetWireName('z', i); //Expected to output to this Z-wire
            var swapWithGate = gateDictionary.FirstOrDefault(kvp => kvp.Value == zOut);    // Find the gate that currently has zOut to swap with

            //Make the swap
            SetCorrectWire(x_xor_y, "XOR", carryInWire, zOut);
            SetCorrectWire(swapWithGate.Key.w1,swapWithGate.Key.op, swapWithGate.Key.w2, faultyZ);

            // Store swapped wires for result
            swappedWires.Add(faultyZ);
            swappedWires.Add(zOut);
            Console.WriteLine($"Replaced output {faultyZ} with {zOut}");
            return false;
        }

        // Carry out bit = x_an_y OR (cin XOR (x_and_y)) 
        var x_and_y = GetOutWireFromGate(x, "AND", y);
        x_xor_y = GetOutWireFromGate(x, "XOR", y);
        
        if (string.IsNullOrEmpty(x_and_y))
        {
            Console.WriteLine($"No gate found for {x} AND {y}");
            throw new InvalidDataException();
        }

        var xor_and_cin = GetOutWireFromGate(x_xor_y, "AND", carryInWire);

        var carryOutWire = string.Empty;
        
        if (string.IsNullOrEmpty(xor_and_cin) || xor_and_cin.StartsWith("z"))
        {
            carryOutWire = x_and_y;
        }
        else
        {
            carryOutWire = GetOutWireFromGate(x_and_y, "OR", xor_and_cin);
        }

        if (string.IsNullOrEmpty(carryOutWire))
        {
            Console.WriteLine($"No gate found for {x_and_y} OR {xor_and_cin}");
            throw new InvalidDataException();
        }

        carryBit.Add(z, carryOutWire);
    }

    return true;
}

void SetCorrectWire(string w1, string op, string w2, string output)
{
    if (gateDictionary.ContainsKey((w1, op, w2)))
    {
        gateDictionary[(w1, op, w2)] = output;
    }
    else if (gateDictionary.ContainsKey((w2, op, w1)))
    {
        gateDictionary[(w2, op, w1)] = output;
    }
    else
    {
        throw new InvalidDataException();
    }
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