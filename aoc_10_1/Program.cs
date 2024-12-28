// See https://aka.ms/new-console-template for more information
using System.Data;

var grid = File.ReadAllLines("input.txt").Select(x => x.ToArray().Select(y => int.Parse(y.ToString())).ToArray()).ToArray();
var trailHeads = new List<(int row, int col)>();
var ends = new HashSet<(int row, int col)>();
var trails = 0; 

for (var i = 0; i < grid.Length; i++)
{
    for (var j = 0; j<grid[i].Length; j++)
    {
        if(grid[i][j] == 0)
        {
            trailHeads.Add((i, j));
        }
    }
}

for (var i = 0; trailHeads.Count > i; i++)
{    
    Traverse(trailHeads[i].row, trailHeads[i].col);
    trails += ends.Count;
    ends.Clear();
}

void Traverse(int row, int col)
{
    var startRow = row;
    var startCol = col;

    if (row - 1 >= 0)
    {
        var next = grid[row - 1][col];

        if (next == 9)
        {
            ends.Add((row - 1, col));
        }
        else if (next == grid[row][col] + 1)
        {
            Traverse(row - 1, col);
        }
    }

    if (row + 1 < grid.Length)
    {
        var next = grid[row + 1][col];
        if (next == grid[row][col] + 1)
        {
            if (next == 9)
            {
                ends.Add((row + 1, col));
            }
            else
            {                
                Traverse(row + 1, col);
            }            
        }
    }

    if (col - 1 >= 0)
    {
        var next = grid[row][col - 1];

        if (next == grid[row][col] + 1)
        {
            if (next == 9)
            {
                ends.Add((row, col -1));
            }
            else
            {
                Traverse(row, col - 1);
            }
        }
    }

    if (col + 1 < grid[0].Length)
    {
        var next = grid[row][col + 1];

        if (next == grid[row][col] + 1)
        {
            if (next == 9)
            {
                ends.Add((row, col + 1));
            }
            else
            {
                Traverse(row, col + 1);
            }
        }
    }
}


Console.WriteLine($"Trailheads: {trailHeads.Count}");
Console.WriteLine($"Trails {trails}");
