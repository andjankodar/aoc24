
using System.Text;
using System.Text.RegularExpressions;

var input = File.ReadAllLines("input.txt");

long regA = 0;
long regB = 0;
long regC = 0;
var program = new List<int>();


foreach (var line in input)
{
    if (line.StartsWith("Register A"))
    {
        regA = long.Parse(Regex.Matches(line, "(\\d+)").First().Value);
    }

    if (line.StartsWith("Register B"))
    {
        regB = int.Parse(Regex.Matches(line, "(\\d+)").First().Value);
    }

    if (line.StartsWith("Register C"))
    {
        regC = int.Parse(Regex.Matches(line, "(\\d+)").First().Value);
    }

    if (line.StartsWith("Program"))
    {
        var matches = Regex.Matches(line, "(\\d+)");

        foreach (var match in matches)
        {
            program.Add(int.Parse(match?.ToString()));
        }
    }
}

var progString = string.Join(",", program);
var done = false;
CalcRegisterA(0);

void CalcRegisterA(long seed)
{
    // 8 is my denominator in the regA calculation in my program since my combo operand is 3
    for (long i = seed * 8; i < (seed + 1) * 8; i++)
    {
        if(done)
        {
            break;
        }

        var output = RunProgram((long)i);
        var outputString = string.Join(",", output);

        if(outputString.Equals(progString, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"RegA: {i}. Output: {outputString}");
            done = true;
        }

        if (!done && Compare(output.ToArray()))
        {
            CalcRegisterA(i);
        }
    }
}

bool Compare(long[] output)
{
    for (var i = 0; i < output.Length; i++)
    {
        if (program[program.Count -1 - i] != output[output.Length - 1 - i])
        {
            return false;
        }
    }

    return true;
}

List<long> RunProgram(long A)
{
    var output = new List<long>();
    ResetBc();
    regA = A;

    for (int i = 0; i < program.Count - 1;)
    {
        var opCode = program[i];
        var operand = program[i + 1];
        long comboOperand = GetComboOperand(operand);

        switch (opCode)
        {
            case 0:
                regA = (long)(regA / Math.Pow(2, comboOperand)); // Always regA = (regA / 8)
                i += 2;
                break;
            case 1:
                regB = regB ^ program[i + 1];
                i += 2;
                break;
            case 2:
                regB = comboOperand % 8;
                i += 2;
                break;
            case 3:
                if (regA != 0)
                {
                    i = program[i + 1];
                }
                else
                {
                    i += 2;
                }
                break;
            case 4:
                regB = regB ^ regC;
                i += 2;
                break;
            case 5:
                var op = comboOperand % 8;
                output.Add(op);
                i += 2;
                break;
            case 6:
                regB = (long)(regA / Math.Pow(2, comboOperand));
                i += 2;
                break;
            case 7:
                regC = (long)(regA / Math.Pow(2, comboOperand));
                i += 2;
                break;
        }
    }
    return output;
}

long GetComboOperand(int input)
{
    switch (input)
    {
        case 0:
        case 1:
        case 2:
        case 3:
            return input;
        case 4:
            return regA;
        case 5:
            return regB;
        case 6:
            return regC;
        case 7:
            throw new InvalidOperationException();            
        default:
            throw new InvalidOperationException();
    }
}

void ResetBc()
{
    foreach (var line in input)
    {
        if (line.StartsWith("Register B"))
        {
            regB = int.Parse(Regex.Matches(line, "(\\d+)").First().Value);
        }

        if (line.StartsWith("Register C"))
        {
            regC = int.Parse(Regex.Matches(line, "(\\d+)").First().Value);
        }
    }
}
