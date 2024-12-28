using System.Text;
using System.Text.RegularExpressions;

var input = File.ReadAllLines("input.txt");

var regA = 0;
var regB = 0;
var regC = 0;
var program = new List<int>();

foreach (var line in input)
{
    if(line.StartsWith("Register A"))
    {
        regA = int.Parse(Regex.Matches(line, "(\\d+)").First().Value);
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

var sb = new StringBuilder();

for(int i = 0; i < program.Count - 1;)
{
    var opCode = program[i];
    var operand = program[i+1];
    var comboOperand = GetComboOperand(operand);
    
    switch(opCode)
    {
        case 0:
            regA = (int)(regA / Math.Pow(2, comboOperand));
            i+=2;
            break;
        case 1:
            regB = regB ^ program[i + 1];
            i+=2;
            break;
        case 2:
            regB = comboOperand % 8;
            i+=2;
            break;
        case 3:
            if(regA != 0)
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
            i+=2;
            break;
        case 5:
            sb.Append(comboOperand % 8);
            sb.Append(",");
            i+=2;
            break;
        case 6:
            regB = (int)(regA / Math.Pow(2, comboOperand));
            i+=2;
            break;
        case 7:
            regC = (int)(regA / Math.Pow(2, comboOperand));
            i+=2;
            break;
    }
}

Console.WriteLine(sb.ToString().TrimEnd(','));

int GetComboOperand(int input)
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
            Console.WriteLine("Error combo 7");
            return 0;
        default:
            Console.WriteLine("Error");
            return 0;
    }
}
