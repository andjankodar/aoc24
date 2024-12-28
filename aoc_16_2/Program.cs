using System.Collections.Immutable;

var grid = File.ReadAllLines("input.txt").Select(x => x.ToArray()).ToArray();
var start = FindStart();

var dc = 1;
var dr = 0;

(int row, int col) FindStart()
{
    for (var i = 0; i < grid.Length; i++)
    {
        for (var j = 0; j < grid[i].Length; j++)
        {
            if (grid[i][j] == 'S')
            {
                return (i, j);
            }
        }
    }

    Console.WriteLine("error");
    return (-1, -1);
}
long? lowestCost = null;
var pathsToEnd = new List<(long score, ImmutableHashSet<(int row, int col)> visited)>();
var positionCosts = new Dictionary<(int, int), long>();
var directions = new List<(int dr, int dc)> { (0, 1), (1, 0), (0, -1), (-1, 0) };

Navigate(start.row, start.col, dr, dc, 0, ImmutableHashSet<(int row, int col)>.Empty);


var uniqueNodes = new HashSet<(int row, int col)>();

foreach (var scorePath in pathsToEnd)
{
    if (scorePath.score == lowestCost)
    {
        foreach (var node in scorePath.visited)
        {
            uniqueNodes.Add(node);
        }
    }
}

Console.WriteLine($"Nodes: {uniqueNodes.Count()}");

void Navigate(int cr, int cc, int dr, int dc, long cost, ImmutableHashSet<(int row, int col)> visited)
{
    if (grid[cr][cc] == '#')
    {
        return;
    }

    if (grid[cr][cc] == 'E')
    {
        if (lowestCost is null || lowestCost >= cost)
        {
            lowestCost = cost;
            var path = visited.Add((cr, cc));
            pathsToEnd.Add((cost, path));
            return;
        }
    }

    if(cost >= lowestCost)
    {
        return;
    }

    if (visited.Contains((cr, cc)))
    {
        return;
    }

    if (positionCosts.ContainsKey((cr, cc)))
    {
        if (cost > positionCosts[(cr, cc)] + 1001)
        {
            return;
        }

        positionCosts[(cr, cc)] = cost;
    }
    else
    {
        positionCosts.Add((cr, cc), cost);
    }

    // Ahead
    Navigate(cr + dr, cc + dc, dr, dc, cost + 1, visited.Add((cr, cc)));
    // Clockwise
    Navigate(cr + dc, cc - dr, dc, -dr, cost + 1001, visited.Add((cr, cc)));
    // Counter clockwise
    Navigate(cr - dc, cc + dr, - dc, dr, cost + 1001, visited.Add((cr, cc)));
}