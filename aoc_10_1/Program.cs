﻿// See https://aka.ms/new-console-template for more information
using System.Data;

var testInput = """
89010123
78121874
87430965
96549874
45678903
32019012
01329801
10456732
""";

var input = """
967801543219877892110120432456765487321234545
854914678900166743026501501329870398100987656
763023498101255654137432672014981287231892187
012109567692341015048976789023569346542763096
101238747887654320157985989121478965456754345
387345656901298743269834870130327101329805210
296096543214386654978723763243210234910418721
145187762105675667871011054358700195894329652
034219853098734789876012343969656786765012347
124309344565623210985985432878545987787601478
565678234674310301234576501701230834594576569
876569132183087456789632101689321127623987654
985432045092196565410547012678101098210891203
876301896700123478326698763543201543109890312
101216789810156389887789654410892672108701021
560125654327667210796612345329763489807632120
456981011498558976545003459458654308716543031
347876320123443089232117868567761218923784787
210945451056782190101656977657890034874695698
987890102349891001212343980342101125665546788
816543211001230417654322821233211056750036569
105565439814376528740011987344780149821123478
219870126765089439951010476035691231034032107
327892345670129310892312362121003412385221016
456781036789438901765403453438912505496102345
012301095490567812989889854567434676787243212
903432787321054923476798763479823987654356601
876563456434143898565210012189714303498987787
569874894321032387654302100001605212567345698
984965765410101234563218761232556721986432183
673454899006565123870109454343457890673212012
542165678187443012989547823254598012364301501
034078543298332132103456910167652345455677652
125609434701245045892321009878541076210588943
010712549889456756701034569969037889821099812
899823456776321893212103278450126985432178901
701209870125410984345232182321125676589067887
654312565034587654456941091101034389678450996
521023454123898343457850190872765210789321045
438985576540123232567569287963898001679877832
307656987239854101098478016554587123456756921
412587610108763003451289123423696564012345670
653496541067654012760345689510789456703430189
743237832378903009801236776421012329898521278
892106901265012108980109865430101012987630167
""";

var grid = input.Split("\r\n").Select(x => x.ToArray().Select(y => int.Parse(y.ToString())).ToArray()).ToArray();
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
    //Console.WriteLine($"Start at: {trailHeads[i].row},{trailHeads[i].col}");
    Traverse(trailHeads[i].row, trailHeads[i].col);
    //Console.WriteLine($"Trails found {ends.Count}");
    trails += ends.Count;
    ends.Clear();
}

void Traverse(int row, int col)
{
    //Console.WriteLine($"Row: {row},{col}");

    var startRow = row;
    var startCol = col;

    if (row - 1 >= 0)
    {
        var next = grid[row - 1][col];

        if (next == 9)
        {
            //Console.WriteLine($"Found trail to {row - 1}, {col}");
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
                //Console.WriteLine($"Found trail to {row + 1}, {col}");
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
                //Console.WriteLine($"Found trail to {row}, {col -1}");
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
                //Console.WriteLine($"Found trail to {row}, {col+1}");
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
