// See https://aka.ms/new-console-template for more information
using System.Data;

var grid = File.ReadAllLines("input.txt").Select(x => x.ToArray()).ToArray();

var regions = new List<HashSet<(int row, int col)>>();

for (int i = 0; i < grid.Length; i++)
{
    for (int j = 0; j < grid[i].Length; j++)
    {
        if (HasRegion(i, j))
        {
            continue;
        }

        var region = new List<(int row, int col)>();
        var id = grid[i][j];
        MapRegion(id, i, j, region);
        regions.Add(region.ToHashSet());
    }
}

void MapRegion(char id, int row, int col, List<(int row, int col)> region)
{
    if (row < 0 ||
        row >= grid.Length ||
        col < 0 ||
        col >= grid[row].Length ||
        grid[row][col] != id ||
        region.Contains((row, col)))
    {
        return;
    }

    region.Add((row, col));

    MapRegion(id, row - 1, col, region);
    MapRegion(id, row + 1, col, region);
    MapRegion(id, row, col - 1, region);
    MapRegion(id, row, col + 1, region);
}

bool HasRegion(int row, int col)
{
    for (int i = 0; i < regions.Count; i++)
    {
        if (regions[i].Contains((row, col)))
        {
            return true;
        }
    }

    return false;
}

var sum = 0;

for (int i = 0; i < regions.Count; i++)
{
    var downNodes =new List<(int row, int col)>();
    var rightNodes = new List<(int row, int col)>();
    var leftNodes = new List<(int row, int col)>();
    var upNodes = new List<(int row, int col)>();
    var area = regions[i].Count;
    var id = grid[regions[i].First().row][regions[i].First().col];
    var nodes = regions[i].ToArray();

    for (int j = 0; j < nodes.Length; j++)
    {
        var row = nodes[j].row;
        var col = nodes[j].col;

        if (!regions[i].Contains((row - 1, col)))
        {
            upNodes.Add((row, col));
        }
        if (!regions[i].Contains((row, col + 1)))
        {
            rightNodes.Add((row, col + 1));
        }
        if (!regions[i].Contains((row + 1, col)))
        {
            downNodes.Add((row + 1, col));
        }
        if (!regions[i].Contains((row, col - 1)))
        {
            leftNodes.Add((row, col - 1));
        }
    }

    var upsides = new List<HashSet<(int row, int col)>>();
    var downsides = new List<HashSet<(int row, int col)>>();
    var leftsides = new List<HashSet<(int row, int col)>>();
    var rightsides = new List<HashSet<(int row, int col)>>();
    
    var sides = 0;

    void MapSideways(int row, int col, List<(int row, int col)> side, List<(int row, int col)> nodes)
    {
        if(side.Contains((row, col)))
        {
            return;
        }

        side.Add((row, col));

        if(nodes.Contains((row, col - 1)))
        {            
            MapSideways(row, col - 1, side, nodes);
        }

        if (nodes.Contains((row, col + 1)))
        {            
            MapSideways(row, col + 1, side, nodes);
        }
    }

    void MapVertically(int row, int col, List<(int row, int col)> side, List<(int row, int col)> nodes)
    {
        if (side.Contains((row, col)))
        {
            return;
        }

        side.Add((row, col));

        if (nodes.Contains((row-1, col)))
        {
            MapVertically(row-1, col, side, nodes);
        }

        if (nodes.Contains((row+1, col)))
        {
            MapVertically(row+1, col, side, nodes);
        }
    }

    for (int j = 0; j < upNodes.Count; j++)
    {
        if(upsides.Any(s => s.Contains(upNodes[j])))
        {
            continue;
        }

        var side = new List<(int row, int col)>();
        MapSideways(upNodes[j].row, upNodes[j].col, side, upNodes);
        upsides.Add(side.ToHashSet());
    }  


    sides += upsides.Count();

    for (int j = 0; j < downNodes.Count; j++)
    {
        if (downsides.Any(s => s.Contains(downNodes[j])))
        {
            continue;
        }

        var side = new List<(int row, int col)>();
        MapSideways(downNodes[j].row, downNodes[j].col, side, downNodes);
        downsides.Add(side.ToHashSet());
    }

    sides += downsides.Count();

    for (int j = 0; j < leftNodes.Count; j++)
    {
        if (leftsides.Any(s => s.Contains(leftNodes[j])))
        {
            continue;
        }

        var side = new List<(int row, int col)>();
        MapVertically(leftNodes[j].row, leftNodes[j].col, side, leftNodes);
        leftsides.Add(side.ToHashSet());
    }

    sides += leftsides.Count();

    for (int j = 0; j < rightNodes.Count; j++)
    {
        if (rightsides.Any(s => s.Contains(rightNodes[j])))
        {
            continue;
        }

        var side = new List<(int row, int col)>();
        MapVertically(rightNodes[j].row, rightNodes[j].col, side, rightNodes);
        rightsides.Add(side.ToHashSet());
    }

    sides += rightsides.Count();

    sum += area * sides;
}

Console.WriteLine($"Sum: {sum}");
