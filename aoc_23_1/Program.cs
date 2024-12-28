using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

var input = File.ReadAllLines("input.txt");

var connections = GetConnections();
var connectionDictionary = GetConnectionDic();
var networks = new List<HashSet<string>>();
long total = 0;

foreach (var cpu in connectionDictionary.Keys)
{
    if(cpu.StartsWith('t'))
    {
        GetNetsOfThree(cpu);
    }
}

Console.WriteLine($"There are {total} sets of tree");

void GetNetsOfThree(string cpu0)
{
    var connectedToCpu0 = connectionDictionary[cpu0].ToArray();    

    for (var i = 0; i < connectedToCpu0.Length - 1; i++)
    {
        for (var j = 1; j < connectedToCpu0.Length; j++)
        {
            // Both cpu1 and cpu2 are connected to cpu0. Chekc if a and 2 are also connected to eachother
            var cpu1 = connectedToCpu0[i];
            var cpu2 = connectedToCpu0[j];

            if ((connections.Contains((cpu1, cpu2)) || connections.Contains((cpu2, cpu1))) && !IsAlreadyCounted(cpu0, cpu1, cpu2))
            {
                networks.Add(new HashSet<string> { cpu0, cpu1, cpu2 });                
                total++;
            }
        }
    }
}

bool IsAlreadyCounted(string cpu0, string cpu1, string cpu2)
{
    return networks.Any(n => n.Contains(cpu0) && n.Contains(cpu1) && n.Contains(cpu2));
}

(string cpu1, string cpu2)[] GetConnections()
{
    var connections = new HashSet<(string cpu1, string cpu2)>();
    
    foreach (var line in input)
    {
        var matches = Regex.Matches(line, "([a-z]+)");
        var cpu1 = matches[0].Value;
        var cpu2 = matches[1].Value;

        if(!connections.Contains((cpu2, cpu1)))
        {
            connections.Add((cpu1, cpu2));
        }
    }

    return connections.ToArray();
}

Dictionary<string, List<string>> GetConnectionDic()
{
    var connections = new Dictionary<string, List<string>>();

    foreach (var line in input)
    {
        var matches = Regex.Matches(line, "([a-z]+)");
        var cpu1 = matches[0].Value;
        var cpu2 = matches[1].Value;

        if(connections.ContainsKey(cpu1))
        {
            connections[cpu1].Add(cpu2);
        }
        else
        {
            connections.Add(cpu1, new List<string> { cpu2 });
        }

        if (connections.ContainsKey(cpu2))
        {
            connections[cpu2].Add(cpu1);
        }
        else
        {
            connections.Add(cpu2, new List<string> { cpu1 });
        }
    }

    return connections;
}






