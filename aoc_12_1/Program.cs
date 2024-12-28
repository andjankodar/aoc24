
var grid = File.ReadAllLines("input.txt").Select(x => x.ToArray()).ToArray();

var regions = new List<HashSet<(int row, int col)>>();

for (int i = 0; i < grid.Length; i++)
{
    for (int j = 0; j < grid[i].Length; j++)
    {
        if(HasRegion(i,j))
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

    MapRegion(id, row-1, col, region);
    MapRegion(id, row+1, col, region);
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

// CALC fence
var sum = 0;

for (int i = 0; i < regions.Count; i++)
{
    var perimeter = 0;
    var area = regions[i].Count;
    var id = grid[regions[i].First().row][regions[i].First().col];
    var plants = regions[i].ToArray();
    
    for (int j = 0; j < plants.Length; j++)
    {        
        var row  = plants[j].row;
        var col = plants[j].col;
        
        if (!regions[i].Contains((row - 1, col)))
        {
            perimeter++;
        }
        if (!regions[i].Contains((row, col + 1)))
        {
            perimeter++;
        }
        if (!regions[i].Contains((row +1, col)))
        {
            perimeter++;
        }
        if (!regions[i].Contains((row, col-1)))
        {
            perimeter++;
        }
    }

    sum += area * perimeter;

}

Console.WriteLine($"Sum: {sum}");
