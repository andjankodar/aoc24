using System.Collections.Immutable;
using System.ComponentModel;

var directions = new List<(int dr, int dc)> { (0, 1), (1, 0), (0, -1), (-1, 0) };
var grid = File.ReadAllLines("input.txt").Select(x => x.ToArray()).ToArray();
var s = Find('S');
var e = Find('E');

var path = GetPath();
var minCheatTime = 100;
var cheatStartEnd = new Dictionary<(int sr, int sc, int er, int ec), int>();

var seen = new Dictionary<(int row, int col), int>();

FindCheats();
Console.WriteLine($"There are {cheatStartEnd.Count} cheats that save at least {minCheatTime} picoseconds.");

void FindCheats()
{
    // For each step on the path, check where it is possible to cheat to
    for (int i = 0; i < path.Count; i++)
    {
        FindCheatsForStart(path[i].row, path[i].col, i);
    }
}

void FindCheatsForStart(int sr, int sc, int sIndex)
{
    for (var i = path.Count - 1; i > sIndex; i--)
    {
        var end = path[i];
        var dr = Math.Abs(end.row - sr);
        var dc = Math.Abs(end.col - sc);
        var stepsStartToEnd = dr + dc;
        var savedTime = i - sIndex - stepsStartToEnd;
        
        if (dr + dc <= 20 && savedTime >= minCheatTime)
        {
            cheatStartEnd.Add((sr, sc, end.row, end.col), savedTime);           
        }
    }   
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

    return (0, 0);
}

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
            if (grid[i][j] == '.' || grid[i][j] == 'E' || grid[i][j] == 'S')
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
