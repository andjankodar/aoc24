
var grid = File.ReadAllLines("input.txt").Select(x => x.ToArray().Select(y => int.Parse(y.ToString())).ToArray()).ToArray();
var trailHeads = new List<(int row, int col)>();
var ends = new List<(int row, int col)>(); //HashSet for part 1
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

for (var i = 0; i < trailHeads.Count; i++)
{
    Traverse(trailHeads[i].row, trailHeads[i].col);
    trails += ends.Count;
    ends.Clear();
}

void Traverse(int row, int col)
{

    // Up
    if (row - 1 >= 0)
    {
        var next = grid[row - 1][col];

        if (next == grid[row][col] + 1)
        {
            if (next == 9)
            {
                ends.Add((row - 1, col));
            }
            else
            {
                Traverse(row - 1, col);
            }
        }
    }

    // Down
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

    // Left
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


    // Right
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

Console.WriteLine($"Trails {trails}");
