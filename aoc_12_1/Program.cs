// See https://aka.ms/new-console-template for more information
using System.Data;

var testInput = """
    RRRRIICCFF
    RRRRIICCCF
    VVRRRCCFFF
    VVRCCCJFFF
    VVVVCJJCFE
    VVIVCCJJEE
    VVIIICJJEE
    MIIIIIJJEE
    MIIISIJEEE
    MMMISSJEEE
    """;

var grid = testInput.Split("\r\n").Select(x => x.ToArray()).ToArray();
var regions = new List<HashSet<(int row, int col)>>();
var fenced = new HashSet<(int row, int col, int perimiter)>();

for  (int i = 0; i < grid.Length; i++)
{
    for (int j = 0; j < grid[i].Length; j++)
    {
        FindMyRegion(i, j);
    }
}

void FindMyRegion(int row, int col)
{
    var added = false;
    if(row > 0 && grid[row][col] == grid[row - 1][col])
    {
        added = AddToRegion(row, col, row -1, col);
    }
    if(row < grid.Length - 1 && grid[row][col] == grid[row + 1][col])
    {
        added = AddToRegion(row, col, row + 1, col);
    }
    if (col > 0 && grid[row][col] == grid[row][col -1])
    {
        added = AddToRegion(row, col, row, col -1);
    }
    if (col < grid[0].Length -1 && grid[row][col] == grid[row][col + 1])
    {
        added = AddToRegion(row, col, row, col + 1);
    }

    if (!added)
    {
        regions.Add(new HashSet<(int row, int col)> { (row, col) });
    }
}

Console.WriteLine($"There are {regions.Count} regions");

bool AddToRegion(int rowToAdd, int colToAdd, int rowToFind, int colToFind)
{
    var found = false;
    for (int i = 0; i < regions.Count; i++)
    {
        if (regions[i].Contains((rowToFind, rowToFind)))
        {
            regions[i].Add((rowToAdd, colToAdd));
            found = true;
            break;
        }
    }

    return found;
}

void FencePerimiter(int row, int col)
{
    if (row < 0 || row == grid.Length || col < 0 || col == grid[0].Length || fenced.Any(x => x.row == row && x.col == col))
    {
        return;
    }

    var perimiter = 0;

    // Up
    if (row == 0 || grid[row][col] != grid[row - 1][col])
    {
        perimiter++;
    }

    // Down
    if (row == grid.Length - 1 || grid[row][col] != grid[row + 1][col])
    {
        perimiter++;
    }

    // Left
    if (col == 0 || grid[row][col] != grid[row][col - 1])
    {
        perimiter++;
    }

    //Right
    if (col == grid[0].Length -1 || grid[row][col] != grid[row][col + 1])
    {
        perimiter++;
    }

    fenced.Add((row,col, perimiter));
}