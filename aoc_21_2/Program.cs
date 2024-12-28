using System;
using System.Text;
using System.Text.RegularExpressions;

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

var cache = new Dictionary<string, long>();

long total = 0;


foreach (var code in codes)
{
    long presses = 0;

    var inputToLastBot = RemoteToDoorpad(code);
    var splits = SplitA(inputToLastBot);
    
    for (var j = 0; j < splits.Length; j++)
    {
        presses += RemoteToRemote(splits[j], 25);
    }

    var num = int.Parse(code.Substring(0, 3));
    var score = presses * num;
    total += score;
}

Console.WriteLine(total);

long RemoteToRemote(string inputSequence, int depth)
{
    if(depth == 0)
    {
        return inputSequence.Length;
    }

    var key = $"{inputSequence}-{depth}";

    if (cache.ContainsKey(key)) {
        return cache[key];
    }

    var cr = 0;
    var cc = 2;
    long presses = 0;
    var sequence = string.Empty;
    
    for (var j = 0; j < inputSequence.Length; j++)
    {
        var t = FindRemoteIndexOf(inputSequence[j]);
        var tr = t.row;
        var tc = t.col;
        string rowChange = string.Empty;
        string colChange = string.Empty;

        while(cc != tc || cr != tr)
        {
            if (cc > tc && !(tc == 0 && cr == 0))
            {
                while (cc != tc)
                {
                    cc--;
                    sequence += '<';
                }
            }
            else if (cr > tr && !(tr == 0 && cc == 0))
            {
                while (cr != tr)
                {
                    cr--;
                    sequence += '^';
                }
            }
            else if (cr < tr)
            {
                while (cr != tr)
                {
                    cr++;
                    sequence += 'v';
                }
            }
            else if(cc < tc)
            {
                while (cc != tc)
                {
                    cc++;
                    sequence += '>';
                }
            }
        }
        sequence += 'A';
    }

    
    var splits = SplitA(sequence);
    
    for (int i = 0; i < splits.Length ; i++)
    {
        presses += RemoteToRemote(splits[i], depth - 1);
    }
    
    cache.Add(key, presses);
    
    return presses;
}

string RemoteToDoorpad(string input)
{
    var cr = 3;
    var cc = 2;
    var sequence = string.Empty;

    for (var i = 0; i < input.Length; i++)
    {
        var t = FindDoorpadIndexOf(input[i]);
        var tr = t.row;
        var tc = t.col;

        while(cc != tc || cr != tr)
        {
            if(cc > tc && !(tc == 0 && cr == 3))
            {
                while(cc != tc)
                {
                    cc--;
                    sequence += '<';
                }
            }
            else if(cr > tr)
            {
                while(cr != tr)
                {
                    cr--;
                    sequence += '^';
                }
            }
            else if(cr < tr && !(tr == 3 && cc == 0))
            {
                while(cr != tr)
                {
                    cr++;
                    sequence += 'v';
                }
            }
            else if(cc < tc)
            {
                while (cc != tc)
                {
                    cc++;
                    sequence += '>';
                }
            }
        }
        sequence += 'A';
    }

    return sequence;
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

    throw new InvalidOperationException();
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

    throw new InvalidOperationException();
}

string[] SplitA(string input)
{
    var matches = Regex.Matches(input, "(.*?A)");
    return matches.Select(m => m.Value).ToArray();
}