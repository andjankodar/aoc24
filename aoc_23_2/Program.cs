using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

var input = File.ReadAllLines("input.txt");
var connections = GetConnections();
var connectionDictionary = GetConnectionDic();
var largestNet = new HashSet<string>();
var evaluatedNetworks = new HashSet<string>();

var start = Stopwatch.GetTimestamp();
foreach (var cpu in connectionDictionary.Keys)
{
    var network = ImmutableHashSet<string>.Empty;
    BuildNetwork(network.Add(cpu));
}

var result = largestNet.ToArray();
var sorted = largestNet.ToList();
sorted.Sort();
Console.WriteLine($"Largest network {string.Join(",", sorted)}. {sorted.Count} {Stopwatch.GetElapsedTime(start)}");

void BuildNetwork(ImmutableHashSet<string> network)
{
    var sortedNet = network.ToList();
    sortedNet.Sort();
    var key = string.Join(",", sortedNet);
    
    if (evaluatedNetworks.Contains(key))
    {
        return;    
    }

    evaluatedNetworks.Add(key);

    if (largestNet.Count() < network.Count())
    {
        largestNet = network.ToHashSet();
    }

    foreach(var comp in network)
    {
        foreach (var computer in connectionDictionary[comp])
        {
            //This computer has fewer or same connections as the largest network. Ignore.
            if (connectionDictionary[computer].Count() <= largestNet.Count() - 1)
            {
                continue;
            }

            if (network.All(c => connectionDictionary[computer].Contains(c)))
            {
                // This computer is connected to all nodes in network. Add and continue building network
                BuildNetwork(network.Add(computer));
            }
        }
    }
}

(string cpu1, string cpu2)[] GetConnections()
{
    var connections = new HashSet<(string cpu1, string cpu2)>();

    foreach (var line in input)
    {
        var matches = Regex.Matches(line, "([a-z]+)");
        var cpu1 = matches[0].Value;
        var cpu2 = matches[1].Value;

        if (!connections.Contains((cpu2, cpu1)))
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

        if (connections.ContainsKey(cpu1))
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
