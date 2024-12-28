using System.Collections.Immutable;
using System.Text.RegularExpressions;

var input = File.ReadAllLines("input.txt");

int? fewestSteps = null;
var bestPath = new HashSet<(int row, int col)>();
var memSpace = new List<(int row, int col)>();

foreach (var line in input)
{
    var matches = Regex.Matches(line, "(\\d+)").Select(m => int.Parse(m.Value)).ToArray();
    memSpace.Add((matches[1], matches[0]));
}

var tr = 70;
var tc = 70;
var grid = GetMaze(71, 1024);
var stepsToPos = new Dictionary<(int, int), long>();

var spanStart = 0;
var spanEnd = memSpace.Count - 1;


while(spanStart < spanEnd)
{
    var mid = (spanStart + spanEnd) / 2;
    grid = GetMaze(71, mid+1);
    fewestSteps = null;
    stepsToPos.Clear();         
    Navigate(0, 0, ImmutableHashSet<(int row, int col)>.Empty);

    if (fewestSteps != null)
    {
        spanStart = mid + 1;
    }
    else
    {
        spanEnd = mid;
    }
}

Console.WriteLine($"X,Y = {memSpace[spanStart].col},{memSpace[spanStart].row}");

void Navigate(int cr, int cc, ImmutableHashSet<(int row, int col)> visited)
{
    if(cr < 0 || cr >= grid.Length || cc < 0 || cc >= grid[0].Length )
    {
        return;
    }

    if (grid[cr][cc] == '#')
    {
        return;
    }

    if (cr == tr && cc == tc)
    {
        if (fewestSteps is null || fewestSteps >= visited.Count)
        {
            fewestSteps = visited.Count;
            bestPath = visited.Add((tr, tc)).ToHashSet();
            return;
        }
    }

    if (visited.Count >= fewestSteps)
    {
        return;
    }

    if (visited.Contains((cr, cc)))
    {
        return;
    }

    if (stepsToPos.ContainsKey((cr, cc)))
    {
        if (visited.Count >= stepsToPos[(cr, cc)])
        {
            return;
        }

        stepsToPos[(cr, cc)] = visited.Count;
    }
    else
    {
        stepsToPos.Add((cr, cc), visited.Count);
    }

    var hasSeenLeft = stepsToPos.ContainsKey((cr, cc - 1));
    var hasSeenDown = stepsToPos.ContainsKey((cr + 1, cc));
    var hasSeenUp = stepsToPos.ContainsKey((cr - 1, cc));
    var hasSeenRight = stepsToPos.ContainsKey((cr, cc + 1));

    // Right
    Navigate(cr, cc + 1, visited.Add((cr, cc)));

    //Down
    Navigate(cr + 1, cc, visited.Add((cr, cc)));

    // Up
    Navigate(cr - 1, cc, visited.Add((cr, cc)));

    //Left
    Navigate(cr, cc - 1, visited.Add((cr, cc)));
}

char[][] GetMaze(int size, int fallenBytes)
{
    char[][] grid = new char[size][];
    
    for (int i = 0; i < size; i++)
    {
        var row = new char[size];

        for (int j = 0; j < size; j++)
        {
            if (memSpace.Take(fallenBytes).Contains((i, j)))
            {
                row[j] = '#';
            }
            else
            {
                row[j] = '.';
            }            
        }
        grid[i] = row;
    }

    return grid;
}