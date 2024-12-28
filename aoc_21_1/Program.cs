using System;
using System.Text;

var codes = File.ReadAllLines("input.txt");

var doorpad = new char[][]
{
    new char[] { '7', '8', '9'},
    new char[] { '4', '5', '6'},
    new char[] { '1', '2', '3'},
    new char[] { 'X', '0', 'A'},
};

var remote = new char[][]
{
    new char[] { 'X', '^', 'A'},
    new char[] { '<', 'v', '>'}
};

var total = 0;

foreach (var code in codes)
{
    var presses = 0;
    
    var robot2NeedsToPress = RemoteToDoorpad(code);    
    var robotb1NeedsToPress = RemoteToRemote(robot2NeedsToPress);
    var iNeedToPress = RemoteToRemote(robotb1NeedsToPress);
    presses = iNeedToPress.Length;
    var num = int.Parse(code.Substring(0, 3));
    var score = presses * num;
    total += score;
}

Console.WriteLine(total);

var dp = new List<Dictionary<char, string>>();

string RemoteToDoorpad(string input)
{
    var cr = 3;
    var cc = 2;  
    var output = new StringBuilder();
    
    for (var i = 0; i < input.Length; i++)
    {
        // Robot 3 - pressing codepad
        var buttonTarget = FindDoorpadIndexOf(input[i]);
        var dr = buttonTarget.row - cr;
        var dc = buttonTarget.col - cc;

        string rowChange = string.Empty;
        string colChange = string.Empty;

        // Find what robot 2 needs to press to make robot 3 input the code
        if (dr < 0)
        {
            rowChange = new string('^', Math.Abs(dr));
        }
        else if (dr > 0)
        {
            rowChange = new string('v', dr);
        }

        if (dc < 0)
        {
            colChange = new string('<', Math.Abs(dc));
        }
        else if (dc > 0)
        {
            colChange = new string('>', dc);
        }

        var sequence = string.Empty;

        if (cc + dc == 0 && cr == 3 || dr > 0)
        {
            sequence = rowChange + colChange;
        }
        else
        {
            sequence = colChange + rowChange;
        }

        output.Append(sequence + "A");
        cr += dr;
        cc += dc;       

    }

    return output.ToString();
}

string RemoteToRemote(string input)
{
    var cr = 0;
    var cc = 2;
    var output = new StringBuilder();

    for (var j = 0; j < input.Length; j++)
    {
        var targetButton = FindRemoteIndexOf(input[j]);
        var dr = targetButton.row - cr;
        var dc = targetButton.col - cc;
        string rowChange = string.Empty;
        string colChange = string.Empty;

        if (dr < 0)
        {
            rowChange = new string('^', Math.Abs(dr));
        }
        else if (dr > 0)
        {
            rowChange = new string('v', dr);
        }

        if (dc < 0)
        {
            colChange = new string('<', Math.Abs(dc));
        }
        else if (dc > 0)
        {
            colChange = new string('>', dc);
        }

        var sequence = string.Empty;

        if (cc + dc == 0 && cr == 0 || (dr == 1 && dc < 0))
        {
            sequence += rowChange + colChange;
        }
        else
        {
            sequence += colChange + rowChange;
        }
        output.Append(sequence + "A");
        
        cr += dr;
        cc += dc;
    }

    return output.ToString();
}

(int row, int col) FindDoorpadIndexOf(char ch)
{
    for (int i = 0; i < doorpad.Length; i++)
    {
        for (int j = 0; j < doorpad[i].Length; j++)
        {
            if (doorpad[i][j] == ch)
            {
                return (i, j);
            }
        }
    }

    return (-1, -1);
}

(int row, int col) FindRemoteIndexOf(char ch)
{
    for (int i = 0; i < remote.Length; i++)
    {
        for (int j = 0; j < remote[i].Length; j++)
        {
            if (remote[i][j] == ch)
            {
                return (i, j);
            }
        }
    }

    return (-1, -1);
}

