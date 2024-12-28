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
            if(grid[i][j] == 'S')
            {
                return (i, j);
            }
        }
    }

    Console.WriteLine("error");
    return (-1, -1);
}
var scores = new List<long>();

var posScores = new Dictionary<(int, int), long>();

var directions = new List<(int dr, int dc)> { (0, 1), (1, 0), (0, -1), (-1, 0) };
Navigate(start.row, start.col, dr, dc, 0, ImmutableHashSet<(int row, int col)>.Empty);

scores.Sort();
Console.WriteLine($"Score: {scores.First()}");

void Navigate(int cr, int cc, int dr, int dc, long score, ImmutableHashSet<(int row, int col)> visited)
{
    if (grid[cr][cc] == '#')
    {
        return;
    }

    if (grid[cr][cc] == 'E')
    {
        scores.Add(score);
        return;
    }

    if (visited.Contains((cr, cc)))
    {
        return;
    }

    if (posScores.ContainsKey((cr, cc)))
    {
        if (score > posScores[(cr, cc)])
        {
            return;
        }
        posScores[(cr, cc)] = score;
    }
    else
    {
        posScores.Add((cr, cc), score);
    }

    foreach (var dir in directions)
    {
        long newScore = 0;
       
        if(dir.dr * -1 == dr && dir.dc * -1 == dc)
        {
            newScore = score + 2001;
        }
        else if (dir.dr == dr && dir.dc == dc)
        {
            newScore = score + 1;
        }
        else
        {
            newScore = score + 1001;
        }

        Navigate(cr + dir.dr, cc + dir.dc, dir.dr, dir.dc, newScore, visited.Add((cr, cc)));     
    }
}

























HashSet<(int row, int col)> NewPath(HashSet<(int row, int col)> currentPath)
{
    var newPath = new HashSet<(int row, int col)>();

    foreach (var step in currentPath)
    {
        newPath.Add(step);
    }    

    return newPath;
}

//void Navigate(int cr, int cc, int dr, int dc, long score, HashSet<(int row, int col, int dr, int dc)> path)
//{
//    if (!path.Add((cr, cc, dr, dc)))
//    {
//        Console.WriteLine("We've been here");
//        return;
//    }

//    if (grid[cr + dr][cc + dc] == 'E')
//    {
//        Console.WriteLine("End");
//        scores.Add(score++);
//        return;
//    }

//    if (grid[cr + dr][cc + dc] == '.')
//    {
//        Navigate(cr + dr, cc + dc, dr, dc, score++, NewPath(path)); //Go same direction
//    }

//    //Turn CW
//    var cwdr = 0;
//    var cwdc = 0;

//    if (dr == 0 && dc == 1)
//    {
//        cwdr = 1;
//        cwdc = 0;
//    }
//    else if (dr == 1 && dc == 0)
//    {
//        cwdr = 0;
//        cwdc = -1;
//    }
//    else if (dr == 0 && dc == -1)
//    {
//        cwdr = -1;
//        cwdc = 0;
//    }
//    else
//    {
//        cwdr = 0;
//        cwdc = 1;
//    }

//    if (!path.Contains((cr, cc, cwdr, cwdc)))
//    {
//        path.Add((cr, cc, cwdr, cwdc));
//        Navigate(cr, cc, cwdr, cwdc, score + 1000, NewPath(path)); //Turned 90 CW
//    }

//    //Turn CW
//    var ccwdr = 0;
//    var ccwdc = 0;

//    if (dr == 0 && dc == 1)
//    {
//        cwdr = -1;
//        cwdc = 0;
//    }
//    else if (dr == 1 && dc == 0)
//    {
//        cwdr = 0;
//        cwdc = 1;
//    }
//    else if (dr == 0 && dc == -1)
//    {
//        cwdr = 1;
//        cwdc = 0;
//    }
//    else
//    {
//        cwdr = 0;
//        cwdc = -1;
//    }

//    if (!path.Contains((cr, cc, ccwdr, ccwdc)))
//    {
//        path.Add((cr, cc, cwdr, cwdc));
//        Navigate(cr, cc, ccwdr, ccwdc, score + 1000, NewPath(path)); //Turned 90 CW
//    }
//}