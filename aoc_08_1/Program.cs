
var grid = File.ReadAllLines("input.txt").Select(x => x.Trim().ToArray()).ToArray();
var antennaDictionary = new Dictionary<char, List<(int row, int col)>>();

for (var i  = 0; i < grid.Length; i++)
{
    for (var j = 0; j < grid[i].Length; j++)
    {
        if(grid[i][j] == '.')
        {
            continue;
        }

        if (antennaDictionary.ContainsKey(grid[i][j]))
        {
            antennaDictionary[grid[i][j]].Add((i,j));
        }
        else
        {
            antennaDictionary.Add(grid[i][j], new List<(int row, int col)> { (i,j) });
        }
    }
}

var keys = antennaDictionary.Keys.ToArray();
var antinodes = new HashSet<(int row, int col)>();

for (var i = 0; i < keys.Length; i++)
{
    var locations = antennaDictionary[keys[i]].ToArray();

    if(locations.Length < 2 )
    {
        continue;
    }

    for (var j = 0; j < locations.Length -1; j++)
    {
        for (var k = j+1; k < locations.Length; k++)
        {
            var dr = locations[k].row - locations[j].row;
            var dc = locations[k].col - locations[j].col;
            var adr = Math.Abs(dr);
            var adc = Math.Abs(dc);

            if (dr < 0 && dc < 0) // j below k and j right of k
            {
                AddLocationIfValid(locations[k].row - adr, locations[k].col - adc);
                AddLocationIfValid(locations[j].row + adr, locations[j].col + adc);
            }
            else if (dr < 0 && dc > 0) // j below k and j left of k
            {
                AddLocationIfValid(locations[k].row - adr, locations[k].col + adc);
                AddLocationIfValid(locations[j].row + adr, locations[j].col - adc);
            }
            else if (dr > 0 && dc > 0) // j above k and j left of k
            {
                AddLocationIfValid(locations[k].row + adr, locations[k].col + adc);
                AddLocationIfValid(locations[j].row - adr, locations[j].col - adc);
            }
            else if (dr > 0 && dc < 0) // j above k and j right of k
            {
                AddLocationIfValid(locations[k].row + adr, locations[k].col - adc);
                AddLocationIfValid(locations[j].row - adr, locations[j].col + adc);
            }
            else
            {
                Console.WriteLine($"Error on line {i}");
            }
        }
    }
}

Console.WriteLine($"There are {antinodes.Count} antinodes");

bool AddLocationIfValid(int row, int col)
{
    if (row >= 0 && row < grid.Length && col >= 0 && col < grid[0].Length)
    {
        return !antinodes.Add((row, col));
    }

    return false;
}