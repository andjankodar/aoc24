﻿using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

var grid = File.ReadAllLines("input.txt").Select(x => x.ToArray()).ToArray();
var s = Find('S');
var e = Find('E');
long? fewestSteps = null;
var directions = new List<(int dr, int dc)> { (0, 1), (1, 0), (0, -1), (-1, 0) };

var path = GetPath();
fewestSteps = path.Count - 1;

// Find possible points to cheat at
var cheats = FindCheatNodes();
var total = 0;

// Find all cheats that cut at least 100 steps
for (var i = 0; i < cheats.Length; i++)
{
    if (path.Contains((cheats[i].row - 1, cheats[i].col)) && path.Contains((cheats[i].row + 1, cheats[i].col)))
    {
        var node1 = (cheats[i].row - 1, cheats[i].col);
        var node2 = (cheats[i].row + 1, cheats[i].col);
        
        if (Math.Abs(path.IndexOf(node1) - path.IndexOf(node2)) >= 102)
        {
            total++;
        }
    }
    else if(path.Contains((cheats[i].row, cheats[i].col - 1)) && path.Contains((cheats[i].row, cheats[i].col + 1)))
    {
        var node1 = (cheats[i].row, cheats[i].col - 1);
        var node2 = (cheats[i].row, cheats[i].col + 1);

        if (Math.Abs(path.IndexOf(node1) - path.IndexOf(node2)) >= 102)
        {
            total++;
        }
    }
}

Console.WriteLine($"There are {total} cheats that save at least 100 picoseconds.");

List<(int row, int col)> GetPath()
{
    var pathNodes = new HashSet<(int row, int col)>();

    var path = new List<(int row, int col)>();
    path.Add(s);

    // Find all nodes on the path
    for (int i = 1; i < grid.Length - 1; i++)
    {
        for (int j = 1; j < grid[i].Length - 1; j++)
        {
            if (grid[i][j] == '.' || grid[i][j] == 'E' || grid[i][j] == 'S' )
            {
                pathNodes.Add((i, j));
            }
        }
    }

    // Order path
    while (path.Count < pathNodes.Count)
    {
        var current = path.Last();

        foreach (var dir in directions)
        {
            if (pathNodes.Contains((current.row + dir.dr, current.col + dir.dc)) && !path.Contains((current.row + dir.dr, current.col + dir.dc)))
            {
                path.Add((current.row + dir.dr, current.col + dir.dc));
                break;
            }
        }
    }

    return path.ToList();
}

(int row, int col)[] FindCheatNodes()
{
    var cheatNodes = new HashSet<(int row, int col)>();

    for (int i = 1; i < grid.Length - 1; i++)
    {
        for (int j = 1; j < grid[i].Length - 1; j++)
        {
            if (grid[i][j] == '#')
            {
                if ((grid[i - 1][j] != '#' && grid[i + 1][j] != '#') || (grid[i][j - 1] != '#' && grid[i][j + 1] != '#'))
                    cheatNodes.Add((i, j));
            }
        }
    }

    return cheatNodes.ToArray();
}

(int row, int col) Find(char ch)
{
    for (var i = 0; i < grid.Length; i++)
    {
        for (var j = 0; j < grid[i].Length; j++)
        {
            if (grid[i][j] == ch)
            {
                return (i, j);
            }
        }
    }

    return(0,0);
}
